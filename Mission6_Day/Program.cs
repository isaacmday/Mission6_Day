using Microsoft.EntityFrameworkCore;
using Mission6_Day.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add SQLite 
builder.Services.AddDbContext<MoviesContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:FirstConnection"]);
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();