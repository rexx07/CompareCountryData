using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain;

public class TextEntity
{
    [BsonElement]
    public string? Text { get; set; }
}