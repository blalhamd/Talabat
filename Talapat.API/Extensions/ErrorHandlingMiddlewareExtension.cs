namespace Talabat.API.Extensions
{
    public static class ErrorHandlingMiddlewareExtension 
    {
        public static IApplicationBuilder UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ErrorHandlingMiddleWare>();
        }
    }
}
