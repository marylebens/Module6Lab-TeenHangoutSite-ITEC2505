var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Add this line to enable serving static files
// Basic HTML pages
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
