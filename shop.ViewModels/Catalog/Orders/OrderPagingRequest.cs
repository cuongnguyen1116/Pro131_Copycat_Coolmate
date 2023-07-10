using shop.Data.Enums;
using shop.ViewModels.Common;

namespace shop.ViewModels.Catalog.Orders
{
    public class OrderPagingRequest : PagingRequestBase
    {
        public OrderStatus Status { get; set; }

        public string? KeyWord { get; set; }
    }
}
