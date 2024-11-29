using Inance_MVC_tASK.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<InanceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSql")));
var app = builder.Build();
app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(name: "Default", pattern: "{controller=Home}/{action=Index}");
app.UseStaticFiles();

app.Run();
