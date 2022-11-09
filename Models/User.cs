using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace dotnet_mongodb.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? Date { get; set; } = DateTime.Now;
    }
}
