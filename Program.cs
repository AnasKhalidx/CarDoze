using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CarDoze.Models;
using Microsoft.Extensions.Hosting;
using CarDoze.Models.Repository;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddDbContext<CarDozeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddControllersWithViews();

// Register the EmailSender service
builder.Services.AddSingleton<IEmailSender, EmailSender>();
// HttpContext accessor
builder.Services.AddHttpContextAccessor();

// ASP.NET Core Identity configuration with roles
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>() // Ensure roles are supported
    .AddEntityFrameworkStores<CarDozeDbContext>();

// Razor Pages and MVC Controllers
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

// Register repository services
builder.Services.AddScoped<IRepository<Car>, CarRepository>();
builder.Services.AddScoped<IRepository<Manufacturer>, ManufacturerRepository>();
builder.Services.AddScoped<IRepository<Partnership>, PartnershipRepository>();
builder.Services.AddScoped<IRepository<CompareCar>, CompareCarRepository>();
builder.Services.AddScoped<IRepository<Company>, CompanyRepository>();
builder.Services.AddScoped<IRepository<Notification>, NotificationRepository>();
builder.Services.AddScoped<IRepository<Order>, OrderRepository>();
builder.Services.AddScoped<IRepository<Review>, ReviewRepository>();
builder.Services.AddScoped<IRepository<Wishlist>, WishlistRepository>();
builder.Services.AddScoped<IRepository<CarFeature>, CarFeatureRepository>();
builder.Services.AddScoped<IRepository<CarCarFeature>, CarCarFeatureRepository>();
builder.Services.AddScoped<IRepository<ShippingAddress>, ShippingAddressRepository>();
builder.Services.AddScoped<IRepository<CarModels>, CarModelRepository>();

// Configure JSON options
builder.Services.AddControllersWithViews()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.WriteIndented = true; // Makes the output JSON easier to read, useful for debugging
    });

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Global exception handling
app.UseExceptionHandler(c => c.Run(async context =>
{
    var exception = context.Features.Get<IExceptionHandlerPathFeature>()?.Error;
    var response = new { Error = exception?.Message };
    await context.Response.WriteAsJsonAsync(response);
}));

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // Map controller routes
    endpoints.MapControllerRoute(
        name: "admin",
        pattern: "admin",
        defaults: new { controller = "Cars", action = "Index" }
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    // Map Razor Pages
    endpoints.MapRazorPages();
});

app.Run();
