namespace NorthWind.Sales.BusinessObjetcs.Aggregates
{
    public class OrderAggregate : Order
    {
        private readonly List<OrderDetail> OrderDetailsField =
        new List<OrderDetail>();

        public IReadOnlyCollection<OrderDetail> OrderDetails =>
            OrderDetailsField;

        // Agregar el detalle de la orden.
        // Si ya se agregó un ID de producto previamente, sumar la cantidad.
        private void AddDetail(OrderDetail orderDetail)
        {
            var ExistingOrderDetail =
                OrderDetailsField.FirstOrDefault(
                    o => o.ProductId == orderDetail.ProductId);

            if (ExistingOrderDetail != default)
            {
                OrderDetailsField.Add(
                    ExistingOrderDetail with
                    {
                        Quantity = (short)
                        (ExistingOrderDetail.Quantity +
                        orderDetail.Quantity)
                    });

                OrderDetailsField.Remove(ExistingOrderDetail);
            }
            else
            {
                OrderDetailsField.Add(orderDetail);
            }
        }

        public void AddDetail(int productId,
            decimal unitPrice, short quantity) =>
            AddDetail(new OrderDetail(
                productId, unitPrice, quantity));
    }
}