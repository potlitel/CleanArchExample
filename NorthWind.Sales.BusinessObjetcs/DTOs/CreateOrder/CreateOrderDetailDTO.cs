﻿namespace NorthWind.Sales.BusinessObjetcs.DTOs.CreateOrder
{
    public class CreateOrderDetailDTO
    {
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }
}