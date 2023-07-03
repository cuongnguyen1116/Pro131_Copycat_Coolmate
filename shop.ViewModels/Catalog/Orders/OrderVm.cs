using shop.Data.Enums;

namespace shop.ViewModels.Catalog.Orders
{
    public class OrderVm
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string OrderCode { get; set; }
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
    }
}
