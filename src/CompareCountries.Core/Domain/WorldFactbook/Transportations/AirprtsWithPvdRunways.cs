using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     PvdAirprtsWithPvdRunways is a submodel of Transportation model.
/// </summary>
[DisplayName("Airports - with paved runways")]
public class AirprtsWithPvdRunways
{
    [BsonElement("under 914 m")] public PvdVerySmallLength? PvdVerySmallLength { get; set; }

    [BsonElement("914 to 1,524 m")] public PvdShortLength? PvdShortLength { get; set; }

    [BsonElement("1,524 to 2,437 m")] public PvdMediumLength? PvdMediumLength { get; set; }

    [BsonElement("2,438 to 3,047 m")] public PvdLongLength? PvdLongLength { get; set; }

    [BsonElement("over 3,047 m")] public PvdVeryLongLength? PvdVeryLongLength { get; set; }

    [BsonElement("total")] public PvdlengthTotal? PvdLengthTotal { get; set; }
}

/// <summary>
///     PvdVerySmall is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class PvdVerySmallLength : TextEntity
{
}

/// <summary>
///     PvdShortLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class PvdShortLength : TextEntity
{
}

/// <summary>
///     PvdMediumLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class PvdMediumLength : TextEntity
{
}

/// <summary>
///     PvdLongLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class PvdLongLength : TextEntity
{
}

/// <summary>
///     PvdVeryLongLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class PvdVeryLongLength : TextEntity
{
}

/// <summary>
///     PvdlengthTotal is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class PvdlengthTotal : TextEntity
{
}