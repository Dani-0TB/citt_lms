using citt_lms.Model;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
Configure();
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
}