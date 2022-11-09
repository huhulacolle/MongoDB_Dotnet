using MongoDB.Driver;

namespace dotnet_mongodb.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> query;

        public UserRepository(IDefaultMongoDBConnectionFactory defaultMongoDBConnectionFactory)
        {
            query = defaultMongoDBConnectionFactory.Create();
        }

        public async Task<List<User>> Get() => await query.Find(id => true).ToListAsync();
        public async Task Post(User user) => await query.InsertOneAsync(user);
    }
}
