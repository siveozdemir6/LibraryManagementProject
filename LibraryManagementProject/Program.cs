var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddControllersWithViews();
// Add services for session management
builder.Services.AddSession();

var app = builder.Build();

app.UseSession(); // Enable session management

app.UseStaticFiles(); // Serve static files

app.UseRouting(); // Enable routing


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
