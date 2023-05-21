namespace Restaurant.API.Middlewares
{
    public class CorsMiddleware
    {
        private readonly RequestDelegate _next;

        public CorsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Check if it's a preflight request
            if (context.Request.Method == "OPTIONS")
            {
                // Set the necessary response headers for preflight requests
                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                context.Response.Headers.Add("Access-Control-Allow-Methods", "POST, GET, OPTIONS");
                context.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, Authorization");
                context.Response.StatusCode = 200;
            }
            else
            {
                // Set the Access-Control-Allow-Origin header for regular requests
                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                await _next(context);
            }
        }
    }
}
