namespace NorthWind.Sales.BusinessObjetcs.Interfaces.Ports
{
    public interface ICreateOrderInputPort
    {
        ValueTask Handle(CreateOrderDTO orderDto);
    }
}