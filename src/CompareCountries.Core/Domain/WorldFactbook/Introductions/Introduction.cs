using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Introductions;

public class Introduction : TextEntity
{
    [BsonElement("Background")] public Background? Background { get; set; }
}