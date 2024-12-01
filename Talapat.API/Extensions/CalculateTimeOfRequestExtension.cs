
namespace Talabat.API.Extensions
{
    public static class CalculateTimeOfRequestExtension
    {
        public static IApplicationBuilder UseCalculateTimeOfRequest(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CalculateTimeOfRequest>();
        }
    }
}
