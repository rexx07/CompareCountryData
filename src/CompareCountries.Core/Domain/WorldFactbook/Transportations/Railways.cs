using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     Railways is a submodel of Transportation model.
/// </summary>
public class Railways : ExtraNote
{
    [BsonElement("Narrow gauge")] public NarrowGauge? NarrowGauge { get; set; }

    [BsonElement("Standard gauge")] public StandardGauge? StandardGauge { get; set; }

    [BsonElement("total")] public RailwayTotal? RailwayTotal { get; set; }
}

/// <summary>
///     NarrowGauge is a submodel of Railways model.
/// </summary>
public class NarrowGauge : TextEntity
{
}

/// <summary>
///     StandardGauge is a submodel of Railways model.
/// </summary>
public class StandardGauge : TextEntity
{
}

/// <summary>
///     RailwayTotal is a submodel of Railways model.
/// </summary>
public class RailwayTotal : TextEntity
{
}