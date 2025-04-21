using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace aspnetapp5.Entities
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
