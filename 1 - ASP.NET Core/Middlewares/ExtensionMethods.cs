namespace Middlewares
{
    public static class ExtensionMethods
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

        public static void LogTimeMiddleware(this WebApplication app)
        {
            app.UseMiddleware<LogTimeMiddleware>();
        }
    }
}
