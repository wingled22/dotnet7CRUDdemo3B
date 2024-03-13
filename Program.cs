
using Microsoft.EntityFrameworkCore;
using newFolder.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LibraryContext>( options => 
    options.UseSqlServer("Server=localhost;Database=Library;User ID=SA;Password=VeryStr0ngP@ssw0rd;TrustServerCertificate=true;")
) ;

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
