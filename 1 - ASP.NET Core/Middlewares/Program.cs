using Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<LogTimeMiddleware>();

app.MapRoutes();

app.Run();
