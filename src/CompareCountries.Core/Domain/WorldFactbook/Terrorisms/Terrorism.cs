using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Terrorisms;

public class Terrorism : BaseEntity
{
    [BsonElement("Terrorist groups(s)")] public TerroristGroups? TerroristGroups { get; set; }
}