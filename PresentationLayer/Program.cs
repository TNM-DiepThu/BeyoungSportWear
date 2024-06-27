using BusinessLogicLayer.Services.Implements;
using BusinessLogicLayer.Services.Interface;
using CloudinaryDotNet;

var builder = WebApplication.CreateBuilder(args);
var cloudinaryAccount = new Account("dcv1hoalk", "729284788565283", "BGa7XmLy9BkF91j_gsMZQ-7uY2U");
var cloudinary = new Cloudinary(cloudinaryAccount);
builder.Services.AddSingleton(cloudinary);
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else
{
    app.UseHttpsRedirection();
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
});

app.Run();
