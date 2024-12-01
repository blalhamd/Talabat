namespace Talabat.Core.IServices.Cache
{
    public interface ICacheService
    {
        Task CacheResponseAsync(string cacheKey, object response, TimeSpan duration);
        Task<string?> GetCachedResponse(string cacheKey);
    }
}
