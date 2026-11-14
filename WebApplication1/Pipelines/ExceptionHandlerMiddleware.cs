namespace WebApplication1.Pipelines
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
                int i = 0;
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";
                var error = new ErrorResponse
                {
                    Message = ex.Message,
                    StatusCode = context.Response.StatusCode
                };

                await context.Response.WriteAsJsonAsync(error);
            }
        }
    }
}
