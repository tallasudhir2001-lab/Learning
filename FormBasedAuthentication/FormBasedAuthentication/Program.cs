using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

// 1? Tell ASP.NET we want COOKIE authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        // This is the AUTH COOKIE NAME
        options.Cookie.Name = ".AspNetCore.Cookies";

        // Where to redirect if NOT logged in
        options.LoginPath = "/Account/Login";

        // Where to redirect if logged in but NOT authorized
        options.AccessDeniedPath = "/Account/AccessDenied";

        // Cookie expiration
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);

        // Security flags
        options.Cookie.HttpOnly = true;
        options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
        options.SlidingExpiration = true;
    });
    var app = builder.Build();
    app.UseStaticFiles();
    app.UseRouting();

    // 2? Authentication MUST come before Authorization
    app.UseAuthentication();
    app.UseAuthorization();

app.MapDefaultControllerRoute();
app.Run();
