
/*
 
 Tip: Basket comes from Redis in JsonFormat, Basket must send to Redis in JsonFormat

 so, when GetBasket will Deserilize it when return it.
 too, when Update will serilize it before sending it.

 */
namespace Talabat.DataAccess.Repositories.NonGeneric
{
    /*
     *  In This Repo, I don't talk with Database, I will talk with in-memory data store like Redis,so I did't
     *  add Basket or Item in Context in DbSet,so I will talk with Redis in this repo.
     *  so install StackExchange.Redis package like EF Core
     *  Note, StackExchange.Redis will install in Core, because this package will need it in Repo and Business
     *  so install it in Core alternative install it two times in Business and DataAccess
     *  and don't forget Build solution to see it from Core
     *  
     * **/
    public class BasketRepository : IBasketRepository 
    {
        private readonly IDatabase _database; // It's used to interact with the in-memory database. In this case, it will handle data operations, like saving or retrieving items from the store.

        public BasketRepository(IConnectionMultiplexer connection) //which allows the repository to communicate with the Redis in-memory data store, like Context that talk with Database, here IConnectionMultiplexer will tale with Redis that is in-memory dataStore
        {
            _database = connection.GetDatabase();
        }
        public async Task<Basket?> GetBasketAsync(string BasketId)
        {
            var basket = await _database.StringGetAsync(BasketId);

            return basket.IsNull? null : JsonSerializer.Deserialize<Basket>(basket);
        }

        public async Task<Basket?> UpdateBasketAsync(Basket basket)
        {
            var CreatedOrUpdated = await _database.StringSetAsync(basket.Id, JsonSerializer.Serialize(basket), expiry: TimeSpan.FromDays(1));

            if(!CreatedOrUpdated)
            {
                return null;
            }

            return await GetBasketAsync(basket.Id);
        }

        public async Task<bool> DeleteBasketAsync(string BasketId)
        {
           return await _database.KeyDeleteAsync(BasketId);
        }

    }
}
