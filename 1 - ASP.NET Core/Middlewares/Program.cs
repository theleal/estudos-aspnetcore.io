using Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapRoutes();
app.LogTimeMiddleware();

app.Run();
