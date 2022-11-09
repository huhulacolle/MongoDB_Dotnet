using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace dotnet_mongodb.Infrastucture
{
    public class DefaultMongoDBConnectionFactory : IDefaultMongoDBConnectionFactory
    {
        private readonly IMongoCollection<User> user;

        public DefaultMongoDBConnectionFactory(IOptions<DatabaseSettings> databaseSettings)
        {
            var client = new MongoClient(databaseSettings.Value.ConnectionString);
            var database = client.GetDatabase(databaseSettings.Value.DatabaseName);
            user = database.GetCollection<User>(databaseSettings.Value.CollectionName);
        }

        public IMongoCollection<User> Create() => user;
    }
}
