namespace NorthWind.Sales.BusinessObjetcs.Repositories
{
    public interface INorthWindSalesCommandsRepository : IUnitOfWork
    {
        ValueTask CreateOrder(OrderAggregate order);
    }
}