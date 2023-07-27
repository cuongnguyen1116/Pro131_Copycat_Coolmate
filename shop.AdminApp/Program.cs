using shop.ApiIntegration.Categories;
using shop.ApiIntegration.Colors;
using shop.ApiIntegration.Materials;
using shop.ApiIntegration.Orders;
using shop.ApiIntegration.Products;
using shop.ApiIntegration.Promotions;
using shop.ApiIntegration.Sizes;
using shop.ApiIntegration.Stats;
using shop.ApiIntegration.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IProductApiClient, ProductApiClient>();
builder.Services.AddTransient<ICategoryApiClient, CategoryApiClient>();
builder.Services.AddTransient<IOrderApiClient, OrderApiClient>();
builder.Services.AddTransient<IStatisticsApiClient, StatisticApiClient>();
builder.Services.AddTransient<ISizesApiClient, SizesApiClient>();
builder.Services.AddTransient<IMaterialApiClient, MaterialApiClient>();
builder.Services.AddTransient<IUserApiClient, UserApiClient>();
builder.Services.AddTransient<IColorApiClient, ColorApiClient>();
builder.Services.AddTransient<IPromotionApiClient, PromotionApiClient>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
