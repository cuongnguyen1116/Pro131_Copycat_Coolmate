using Microsoft.AspNetCore.Identity;

namespace shop.Data.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }
    public virtual Cart Cart { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
}
