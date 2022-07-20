using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     NationalAirTransportSystem is a submodel of Transportation model.
/// </summary>
public class NationalAirTransportSystem
{
    [BsonElement("Annual freight traffic on registered air carriers")]
    public AnnualFreightTraffic? AnnualFreightTraffic { get; set; }

    [BsonElement("Annual passenger traffic on registered air carriers")]
    public AnnualPassengerTraffic? AnnualPassengerTraffic { get; set; }

    [BsonElement("Inventory of registered aircraft operated air carriers")]
    public InventoryOfRegisteredAircraft? InventoryOfRegisteredAircraft { get; set; }

    [BsonElement("number of registered air carriers")]
    public NumOfRegisteredCarriers? NumOfRegisteredCarriers { get; set; }
}

/// <summary>
///     AnnualFreightTraffic is a a submodel of NationalAirTransportSystem
/// </summary>
public class AnnualFreightTraffic : TextEntity
{
}

/// <summary>
///     AnnualPassengerTraffic is a a submodel of NationalAirTransportSystem
/// </summary>
public class AnnualPassengerTraffic : TextEntity
{
}

/// <summary>
///     InventoryOfRegisteredAircraft is a a submodel of NationalAirTransportSystem
/// </summary>
public class InventoryOfRegisteredAircraft : TextEntity
{
}

/// <summary>
///     NumOfRegisteredCarriers is a a submodel of NationalAirTransportSystem
/// </summary>
public class NumOfRegisteredCarriers : TextEntity
{
}