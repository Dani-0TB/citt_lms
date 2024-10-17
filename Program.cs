using citt_lms.Model;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Configure();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    // Swagger comfiguration
} 
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{lang=es}/{action=Index}/{id?}");

app.Run();

void Configure() {
    IConfigurationSection db = builder.Configuration.GetSection("DbConfig");
    string? connectionString = db.GetSection("ConnectionString").Value;
    
    if (string.IsNullOrWhiteSpace(connectionString))
    {
        throw new ArgumentNullException();
    }

    MySqlServerVersion version = new (new Version(8, 0, 39));

    builder.Services.AddDbContextPool<LMSContext>(
        options => options.UseMySql(connectionString, version));

    builder.Services
    .AddAuthentication(
        options => {
            options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        }
    )
    .AddCookie(options => {
        options.LoginPath = "/auth/login";
    });
    builder.Services.AddControllersWithViews();

    builder.Services.AddControllers();
    // Add Swagger Documentarion
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(/*options => 
    {
        // options.SwaggerDoc("v1", new OpenApiInfo
        // {
        //     Title = "CITT_WORKSHOP API",
        //     Description = "API for CITT WORKSHOP platform",
        //     Version = "v1"
        // });
    }*/);
}