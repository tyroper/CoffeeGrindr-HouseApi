using System.Collections.Generic;
using System.Threading.Tasks;
using HouseApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace HouseApi.DataAccess
{
    public class MongoDbService
    {
        private readonly IMongoCollection<CoffeeHouse> _coffeeHouseCollection;

        public MongoDbService(IOptions<MongoDbSettings> settings)
        {
            MongoClient client = new MongoClient(settings.Value.ConnectionUri);
            IMongoDatabase database = client.GetDatabase(settings.Value.DatabaseName);
            _coffeeHouseCollection = database.GetCollection<CoffeeHouse>(settings.Value.CollectionName);
        }

        public async Task<List<CoffeeHouse>> GetAsync()
        {
            return await _coffeeHouseCollection.Find(new BsonDocument()).ToListAsync();
        }
        public async Task CreateAsync(CoffeeHouse coffeeHouse)
        {
            await _coffeeHouseCollection.InsertOneAsync(coffeeHouse);
            return;
        }
    }
}