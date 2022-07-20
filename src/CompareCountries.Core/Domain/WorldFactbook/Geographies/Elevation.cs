using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Geographies;

/// <summary>
///     Elevation is a submodel of Geography model.
/// </summary>
public class Elevation
{
    [BsonElement("Highest Point")] public HighesPoint? HighesPoint { get; set; }

    [BsonElement("Lowest Point")] public LowestPoint? LowestPoint { get; set; }

    [BsonElement("Mean elevation")] public MeanElevation? MeanElevation { get; set; }
}

/// <summary>
///     HighestPoint is a submodel of Elevation model.
/// </summary>
public class HighesPoint : TextEntity
{
}

/// <summary>
///     LowestPoint is a submodel of Elevation model.
/// </summary>
public class LowestPoint : TextEntity
{
}

/// <summary>
///     MeanElevation is a submodel of Elevation model.
/// </summary>
public class MeanElevation : TextEntity
{
}