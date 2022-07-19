using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// Capital is a submodel of Government model.
/// </summary>
public class Capital: MetaData
{
    [BsonElement("Daylight saving time")]
    public DaylightSavingTime? DaylightSavingTime { get; set; }
    [BsonElement("Etymology")]
    public EtymologyCapital? Etymology { get; set; }
    [BsonElement("Geographic coordinates")]
    public GeographicCoordinates? GeographicCoordinates { get; set; }
    [BsonElement("Name")]
    public Name? Name { get; set; }
    [BsonElement("Time difference")]
    public TimeDifference? TimeDifference { get; set; }
    [BsonElement("Time zone note")]
    public TimeZoneNote? TimeZoneNote { get; set; }
}

/// <summary>
/// DaylightSavingTime is a submodel of Capital model.
/// </summary>
public class DaylightSavingTime: TextEntity{}

/// <summary>
/// Etymology is a submodel of Capital model.
/// </summary>
public class EtymologyCapital: TextEntity{}

/// <summary>
/// GeographicCoordinates is a submodel of Capital model.
/// </summary>
public class GeographicCoordinates: TextEntity{}

/// <summary>
/// Name is a submodel of Capital model.
/// </summary>
public class Name: TextEntity{}

/// <summary>
/// TimeDifference is a submodel of Capital model.
/// </summary>
public class TimeDifference: TextEntity{}

/// <summary>
/// TimeZoneNote is a submodel of Capital model.
/// </summary>
public class TimeZoneNote: TextEntity{}