namespace shop.ViewModels.Catalog.Carts
{
    public class CartActionRequest
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
    }
}