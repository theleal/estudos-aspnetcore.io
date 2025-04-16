namespace Middlewares
{
    public static class MapGetExtensions
    {
        public static void MapRoutes(this WebApplication app) 
        {
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/TestingTimeLogMiddleware", () => 
            { 
                Thread.Sleep(60000); 
                return "Time elapsed (60000miliseconds) to test middleware"; 
            });
        }
    }
}
