using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Introduction;

public class Introduction: TextEntity
{
    [BsonElement("Background")]
    public Background? Background { get; set; }
}