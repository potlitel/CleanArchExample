using NorthWind.Sales.BusinessObjetcs.DTOs.CreateOrder;
using NorthWind.Sales.BusinessObjetcs.Interfaces.Ports;
using NorthWind.Sales.BusinessObjetcs.Repositories;

namespace NorthWind.Sales.UseCases.CreateOrder
{
    public class CreateOrderInteractor : ICreateOrderInputPort
    {
        private readonly ICreateOrderOutputPort OutputPort;
        private readonly INorthWindSalesCommandsRepository Repository;

        public CreateOrderInteractor(
            ICreateOrderOutputPort outputPort,
            INorthWindSalesCommandsRepository repository
        )
        {
            OutputPort = outputPort;
            Repository = repository;
        }

        public async ValueTask Handle(CreateOrderDTO orderDto)
        {
            var OrderAggregate = new OrderAggregate
            {
                CustomerId = orderDto.CustomerId,
                ShipAddress = orderDto.ShipAddress,
                ShipCity = orderDto.ShipCity,
                ShipCountry = orderDto.ShipCountry,
                ShipPostalCode = orderDto.ShipPostalCode
            };

            foreach (var Item in orderDto.OrderDetails)
            {
                OrderAggregate.AddDetail(Item.ProductId, Item.UnitPrice, Item.Quantity);
            }

            await Repository.CreateOrder(OrderAggregate);
            await Repository.SaveChanges();
            await OutputPort.Handle(OrderAggregate.Id);
        }
    }
}