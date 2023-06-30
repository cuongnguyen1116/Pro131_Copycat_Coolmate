using shop.ViewModels.Common;

namespace shop.ViewModels.System.Users;

public class RoleAssignRequest
{
    public Guid Id { get; set; }
    public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
}
