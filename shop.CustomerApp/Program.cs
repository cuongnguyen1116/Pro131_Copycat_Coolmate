using Microsoft.AspNetCore.Authentication.Cookies;
using shop.ApiIntegration.Carts;
using shop.ApiIntegration.Categories;
using shop.ApiIntegration.Orders;
using shop.ApiIntegration.Products;
using shop.ApiIntegration.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = $"/Account/Index";
    options.AccessDeniedPath = $"/User/Forbiden";

});

builder.Services.AddHttpClient();
builder.Services.AddSession(options => options.IdleTimeout = TimeSpan.FromMinutes(30));
builder.Services.AddTransient<IProductApiClient, ProductApiClient>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<ICategoryApiClient, CategoryApiClient>();
builder.Services.AddTransient<IOrderApiClient, OrderApiClient>();
builder.Services.AddTransient<IUserApiClient, UserApiClient>();
builder.Services.AddTransient<ICartApiClient, CartApiClient>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
//app.UseRequestLocalization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//app.MapControllerRoute(
//    name : "Product Detail"
//    );
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//                     name: "Product Detail",
//                     pattern: "/product/ShowDetail/{id}", new
//                     {
//                         controller = "Product",
//                         action = "ShowDetail"
//                     });
//    endpoints.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.Run();
