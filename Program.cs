using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using NOTESPACK.Data;
using NOTESPACK.Services;
using NOTESPACK.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Servicios
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddHostedService<CampusEventSyncService>();
builder.Services.AddHttpClient();

// Configuración de Cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => { 
        options.Cookie.HttpOnly = true; 
        options.LoginPath = "/login"; 
        options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
        options.SlidingExpiration = true;
    });

builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<EventService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<CustomAuthenticationStateProvider>(provider => 
    (CustomAuthenticationStateProvider)provider.GetRequiredService<AuthenticationStateProvider>());

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var app = builder.Build();


// using (var scope = app.Services.CreateScope())
// {
//     var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
//     context.Database.Migrate(); 
// }

app.UseStaticFiles();
app.UseAntiforgery();
app.UseAuthentication();
app.UseAuthorization();

// Endpoints
app.MapPost("/Account/Login", async (HttpContext context, AuthService authService) =>
{
    var form = await context.Request.ReadFormAsync();
    var email = form["email"].ToString() ?? "";
    var password = form["password"].ToString() ?? "";
    
    var result = await authService.LoginAsync(email, password);
    
    if (result.Status == AuthLoginStatus.Success)
    {
        var user = result.User!;
        var userID = user.Id.ToString();

        var claims = new List<Claim> { 
            new Claim(ClaimTypes.Name, user.Email), 
            new Claim(ClaimTypes.Role, user.Role),
            new Claim("UserId", user.Id.ToString()) 
        };

        await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
            new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme)));
        
        context.Response.Redirect("/");
    }
    else { context.Response.Redirect("/login?error=true"); }
});

app.MapPost("/Account/Logout", async (HttpContext context) =>
{
    await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    context.Response.Redirect("/");
});

app.MapPost("/Account/InactivityLogout", async (HttpContext context) =>
{
  if (context.User?.Identity?.IsAuthenticated == true)
    {
        await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }  
    return Results.Ok();
});

app.MapRazorComponents<NOTESPACK.App>().AddInteractiveServerRenderMode();

app.Run();