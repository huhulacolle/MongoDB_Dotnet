using MongoDB.Driver;

namespace dotnet_mongodb.Interfaces.Infrastructure
{
    public interface IDefaultMongoDBConnectionFactory
    {
        public IMongoCollection<User> Create();
    }
}
