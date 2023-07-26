using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using shop.Application.Catalog.Categories;
using shop.Application.Catalog.Colors;
using shop.Application.Catalog.Materials;
using shop.Application.Catalog.Orders;
using shop.Application.Catalog.Products;
using shop.Application.Catalog.Promotions;
using shop.Application.Catalog.Sizes;
using shop.Application.Catalog.Stats;
using shop.Application.Common.StoreFile;
using shop.Application.System.Roles;
using shop.Application.System.Users;
using shop.Data.Context;
using shop.Data.Entities;
using shop.Utilities.Constants;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString(SystemConstants.MainConnectionString); // "copycate_coolmatedb"

builder.Services.AddDbContext<ShopDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ShopDbContext>().AddDefaultTokenProviders();

builder.Services.AddTransient<IColorServices, ColorServices>();
builder.Services.AddTransient<IMaterialServices, MaterialServices>();
builder.Services.AddTransient<ISizeServices, SizeServices>();
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddTransient<ICategoryServices, CategoryServices>();
builder.Services.AddTransient<IStorageService, FileStorageService>();
builder.Services.AddTransient<IRoleServices, RoleServices>();
builder.Services.AddTransient<IUserServices, UserServices>();
builder.Services.AddTransient<IOrderServices, OrderServices>();
builder.Services.AddTransient<IStatisticsServices, StatisticsServices>();
builder.Services.AddTransient<IPromotionService, PromotionService>();

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
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.Run();
