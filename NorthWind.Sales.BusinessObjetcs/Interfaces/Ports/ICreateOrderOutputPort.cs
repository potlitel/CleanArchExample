namespace NorthWind.Sales.BusinessObjetcs.Interfaces.Ports
{
    public interface ICreateOrderOutputPort
    {
        ValueTask Handle(int orderId);
    }
}