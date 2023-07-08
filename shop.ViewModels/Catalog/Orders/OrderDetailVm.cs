namespace shop.ViewModels.Catalog.Orders
{
    public class OrderDetailVm
    {
        public Guid OrderId { get; set; }
        public Guid ProductDetailId { get; set; }
        public string OrderCode { get; set; }
        public string ImagePath { get; set; }
        public string ProductName { get; set; }
        public decimal SubTotal { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string CustomerName { get; set; }
    }
}
