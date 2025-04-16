using Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseMiddleware<LogTimeMiddleware>();

app.MapGet("/", () => "Hello World!");
app.MapGet("/TestingTimeLogMiddleware", () => { Thread.Sleep(60000); return "Time elapsed (60000miliseconds) to test middleware"; });

app.Run();
