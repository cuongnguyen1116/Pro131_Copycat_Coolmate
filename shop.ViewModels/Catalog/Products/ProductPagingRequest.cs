using shop.ViewModels.Common;

namespace shop.ViewModels.Catalog.Products
{
    public class ProductPagingRequest : PagingRequestBase
    {
        public string? Keyword { get; set; }

        public Guid? CategoryId { get; set; }
    }
}
