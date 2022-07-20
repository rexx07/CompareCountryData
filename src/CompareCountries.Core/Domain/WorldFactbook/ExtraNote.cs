using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook;

/// <summary>
///     Other extra data for the model.
/// </summary>
public class ExtraNote
{
    [BsonExtraElements]
    [BsonElement("note")]
    public string? Note { get; set; }
}