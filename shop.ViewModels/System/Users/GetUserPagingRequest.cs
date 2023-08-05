using shop.ViewModels.Common;

namespace shop.ViewModels.System.Users;

public class GetUserPagingRequest : PagingRequestBase
{
    public string? Keyword { get; set; }
}
