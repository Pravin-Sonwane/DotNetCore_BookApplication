using BookApplication.Repository;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<BookRepository, BookRepository>();
#if DEBUG
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif
var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
      pattern: "{controller=Book}/{action=Index}/{id?}"
);

app.Run();
