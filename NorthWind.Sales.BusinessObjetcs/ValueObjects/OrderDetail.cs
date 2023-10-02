namespace NorthWind.Sales.BusinessObjetcs.ValueObjects
{
    public record struct OrderDetail(
        int ProductId, decimal UnitPrice, short Quantity);
}