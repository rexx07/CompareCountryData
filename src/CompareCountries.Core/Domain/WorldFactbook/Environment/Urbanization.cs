using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environment;

/// <summary>
///     Urbanization is a submodel of Environment model.
/// </summary>
public class Urbanization
{
    [BsonElement("Rate of urbanization")] public RateOfUrbanization? RateOfUrbanization { get; set; }

    [BsonElement("Urban population")] public UrbanPopulation? UrbanPopulation { get; set; }
}

/// <summary>
///     RateOfUrbanization is a submodel of Urbanization model.
/// </summary>
public class RateOfUrbanization : TextEntity
{
}

/// <summary>
///     UrbanPopulation is a submodel of Urbanization model.
/// </summary>
public class UrbanPopulation : TextEntity
{
}