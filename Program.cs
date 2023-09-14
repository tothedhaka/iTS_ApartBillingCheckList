using iTS_ApartBillingCheckList.Areas.Signup.Data;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddRazorPages();

var connectionString = builder.Configuration.GetConnectionString("MySqlConn");
//DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)); 
});

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
//app.MapRazorPages();

app.UseAuthorization();


#region "Disabled Routing"
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapAreaControllerRoute(
//    name: "default",
//    areaName: "Signup",
//    pattern: "{area=Signup}/{controller=Registration}/{action=Create}/{id?}");

//app.MapAreaControllerRoute(
//    name: "default",
//    areaName: "Login",
//    pattern: "{area:Login}/{controller=Home}/{action=Index}/{id?}");


//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapAreaControllerRoute(
//        name: "Signup",
//        areaName: "Signup",
//        pattern: "Signup/{controller=Registration}/{action=Create}/{id?}");

//    endpoints.MapAreaControllerRoute(
//        name: "Login",
//        areaName: "Login",
//        pattern: "Login/{controller=Home}/{action=Index}/{id?}");

//    endpoints.MapControllerRoute(
//      name: "areas",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );

//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");

//});
#endregion


#region "Routing"
#pragma warning disable ASP0014
app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Signup",
        areaName: "Signup",
        pattern: "Signup/{controller=Registration}/{action=Create}/{id?}");

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

});
#endregion

app.Run();
