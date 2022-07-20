using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     Airports is a submodel of Transportation model.
/// </summary>
public class Airports
{
    [BsonElement("total")] public AirportTotal? AirportTotal { get; set; }
}

/// <summary>
///     AirportTotal is a submodel of Airport model.
/// </summary>
public class AirportTotal : TextEntity
{
}