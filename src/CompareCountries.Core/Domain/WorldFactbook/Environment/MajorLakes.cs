using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environment;

/// <summary>
///     MajorLakes is a submodel of Environment model.
/// </summary>
public class MajorLakes
{
    [BsonElement("Fresh water lakes(s)")] public FreshWaterLakes? FreshWaterLakes { get; set; }
}

/// <summary>
///     FreshWaterLakes is a submodel of MajorLakes model.
/// </summary>
public class FreshWaterLakes : TextEntity
{
}