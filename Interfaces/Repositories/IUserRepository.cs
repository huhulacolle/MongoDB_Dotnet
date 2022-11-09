namespace dotnet_mongodb.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public Task<List<User>> Get();
        public Task Post(User user);
     }
}
