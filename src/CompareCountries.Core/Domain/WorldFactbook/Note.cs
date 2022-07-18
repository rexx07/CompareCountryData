using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook;

public class MetaData
{
    [BsonExtraElements]
    public string? Note { get; set; }
}