using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace CompareCountries.Core.Domain;

public class BaseEntity
{
    [Required]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId? Id { get; set; }
}