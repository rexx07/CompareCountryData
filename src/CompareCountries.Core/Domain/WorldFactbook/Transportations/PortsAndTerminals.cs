using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     PortsAndTerminals is a submodel of Transportation model.
/// </summary>
public class PortsAndTerminals : ExtraNote
{
    [BsonElement("Lng terminals(s) (export)")]
    public LngTerminalsExport? LngTerminalsExport { get; set; }

    [BsonElement("Lng terminals(s) (import)")]
    public LngTerminalsImport? LngTerminalsImport { get; set; }

    [BsonElement("Lake port(s)")] public LakePorts? LakePorts { get; set; }

    [BsonElement("Major seaport(s)")] public MajorSeaports? MajorSeaports { get; set; }

    [BsonElement("Oil terminals")] public OilTerminals? OilTerminals { get; set; }

    [BsonElement("River or lake port(s)")] public RiverOrLakePorts? RiverOrLakePorts { get; set; }

    [BsonElement("River port(s)")] public RiverPorts? RiverPorts { get; set; }
}

/// <summary>
///     LngTerminalsExport is a submodel of PortsAndTerminals model.
/// </summary>
public class LngTerminalsExport : TextEntity
{
}

/// <summary>
///     LngTerminalsImport is a submodel of PortsAndTerminals model.
/// </summary>
public class LngTerminalsImport : TextEntity
{
}

/// <summary>
///     LakePorts is a submodel of PortsAndTerminals model.
/// </summary>
public class LakePorts : TextEntity
{
}

/// <summary>
///     MajorSeaports is a submodel of PortsAndTerminals model.
/// </summary>
public class MajorSeaports : TextEntity
{
}

/// <summary>
///     OilTerminals is a submodel of PortsAndTerminals model.
/// </summary>
public class OilTerminals : TextEntity
{
}

/// <summary>
///     RiverOrLakePorts is a submodel of PortsAndTerminals model.
/// </summary>
public class RiverOrLakePorts : TextEntity
{
}

/// <summary>
///     RiverPorts is a submodel of PortsAndTerminals model.
/// </summary>
public class RiverPorts : TextEntity
{
}