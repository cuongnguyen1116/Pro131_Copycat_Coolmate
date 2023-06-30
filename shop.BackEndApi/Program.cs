using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shop.Application.Catalog.Categories;
using shop.Application.Catalog.Colors;
using shop.Application.Catalog.Materials;
using shop.Application.Catalog.Product;
using shop.Application.Catalog.Sizes;
using shop.Application.Common;
using shop.Application.System.Roles;
using shop.Application.System.Users;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Constants;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString(SystemConstants.MainConnectionString);

builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ShopDbContext>().AddDefaultTokenProviders();

builder.Services.AddTransient<IColorServices, ColorServices>();
builder.Services.AddTransient<IMaterialServices, MaterialServices>();
builder.Services.AddTransient<ISizeServices, SizeServices>();
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddTransient<ICategoryServices, CategoryServices>();
builder.Services.AddTransient<IStorageService, FileStorageService>();
builder.Services.AddTransient<IRoleServices,RoleServices>();
builder.Services.AddTransient<IUserServices, UserServices>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
