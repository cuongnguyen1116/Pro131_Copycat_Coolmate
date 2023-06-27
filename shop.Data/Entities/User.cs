using shop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }
        public Status Status { get; set; }
        public Guid? RoleId { get; set; }
        public virtual Cart? Cart { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public virtual Role? Role { get; set; }
    }
}
