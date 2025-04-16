using Serilog;
using System.Diagnostics;

namespace Middlewares
{
    public class MyMiddleware
    {

        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
        }
    }

    public class LogTimeMiddleware
    {
        private readonly RequestDelegate _next;

        public LogTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var sw = Stopwatch.StartNew();

            await _next(context);

            sw.Stop();

            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Log.Information($"Execution lasted {sw.Elapsed.TotalSeconds} seconds, or lasted {sw.Elapsed.TotalMilliseconds} miliseconds");
        }
    }
}
