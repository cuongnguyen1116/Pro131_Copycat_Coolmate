using Microsoft.AspNetCore.Identity;

namespace shop.Data.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DoB { get; set; }
    public Cart Cart { get; set; }
    public List<Order> Orders { get; set; }
}
