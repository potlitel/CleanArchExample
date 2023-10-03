namespace NorthWind.Sales.BusinessObjetcs.Controllers
{
    public interface ICreateOrderController
    {
        ValueTask<int> CreateOrder(CreateOrderDTO order);
    }
}