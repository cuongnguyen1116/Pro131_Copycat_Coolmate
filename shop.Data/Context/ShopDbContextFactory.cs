﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace shop.Data.Context;

public class ShopDbContextFactory : IDesignTimeDbContextFactory<ShopDbContext>
{
    public ShopDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

        var connectionString = configuration.GetConnectionString("Copycate_CoolmateDb");

        var optionsBuilder = new DbContextOptionsBuilder<ShopDbContext>();
        optionsBuilder.UseSqlServer(connectionString);
        return new ShopDbContext(optionsBuilder.Options);
    }
}
