﻿using Microsoft.AspNetCore.Identity;

namespace shop.Data.Entities;

public class AppRole : IdentityRole<Guid>
{
    public string Description { get; set; }
}
