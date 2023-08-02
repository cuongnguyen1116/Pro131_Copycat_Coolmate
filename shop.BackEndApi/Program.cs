using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
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
ConfigurationManager configuration = builder.Configuration;
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
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Shop", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
      {
       {
           new OpenApiSecurityScheme
              {
                 Reference = new OpenApiReference
                 {
                      Type = ReferenceType.SecurityScheme,
                         Id = "Bearer"
                 },
                 Scheme = "oauth2",
                 Name = "Bearer",
                 In = ParameterLocation.Header,
               },
              new List<string>()
                }
            });
});
string issuer = configuration["Tokens:Issuer"];
string signingKey = configuration["Tokens:Key"];
byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidIssuer = issuer,
        ValidateAudience = true,
        ValidAudience = issuer,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = System.TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
    };
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Shop V1");
    });
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
