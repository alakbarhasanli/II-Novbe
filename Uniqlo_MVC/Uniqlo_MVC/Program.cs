using Microsoft.EntityFrameworkCore;
using Uniqlo_MVC.Contexts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UniqloDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));


var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=DashBoard}/{action=Index}/{id?}"
          );

app.MapControllerRoute(name: "Default", pattern: "{controller=Home}/{action=Index}");


app.Run();