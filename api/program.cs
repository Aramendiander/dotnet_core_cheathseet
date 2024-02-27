// Mandatory to build app object
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// Run code on index
app.Run(async (HttpContext context) =>
{
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("Hello");
});

app.Run();
