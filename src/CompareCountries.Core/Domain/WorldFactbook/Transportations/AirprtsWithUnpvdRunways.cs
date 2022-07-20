using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     AirprtsWithPvdRunways is a submodel of Transportation model.
/// </summary>
[DisplayName("Airports - with paved runways")]
public class AirprtsWithUnpvdRunways
{
    [BsonElement("under 914 m")] public UnpvdVerySmallLength? UnpvdVerySmallLength { get; set; }

    [BsonElement("914 to 1,524 m")] public UnpvdShortLength? UnpvdShortLength { get; set; }

    [BsonElement("1,524 to 2,437 m")] public UnpvdMediumLength? UnpvdMediumLength { get; set; }

    [BsonElement("2,438 to 3,047 m")] public UnpvdLongLength? UnpvdLongLength { get; set; }

    [BsonElement("over 3,047 m")] public UnpvdVeryLongLength? UnpvdVeryLongLength { get; set; }

    [BsonElement("total")] public UnpvdlengthTotal? UnpvdLengthTotal { get; set; }
}

/// <summary>
///     UnpvdVerySmall is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class UnpvdVerySmallLength : TextEntity
{
}

/// <summary>
///     SUnpvdhortLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class UnpvdShortLength : TextEntity
{
}

/// <summary>
///     UnpvdMediumLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class UnpvdMediumLength : TextEntity
{
}

/// <summary>
///     UnpvdLongLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class UnpvdLongLength : TextEntity
{
}

/// <summary>
///     UnpvdVeryLongLength is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class UnpvdVeryLongLength : TextEntity
{
}

/// <summary>
///     UnpvdlengthTotal is a submodel of AirprtsWithPvdRunways model.
/// </summary>
public class UnpvdlengthTotal : TextEntity
{
}