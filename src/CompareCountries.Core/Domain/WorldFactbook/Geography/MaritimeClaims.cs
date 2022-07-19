using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Geography;

/// <summary>
/// MaritimeClaims is a submodel of Geography model.
/// </summary>
public class MaritimeClaims: TextEntity
{
    [BsonElement("Contiguous zone")]
    public ContiguousZone? ContiguousZone { get; set; }
    [BsonElement("Contiguous shelf")]
    public ContiguousShelf? ContiguousShelf { get; set; }
    [BsonElement("Exclusive economic zone")]
    public ExclusiveEconomicZone? ExclusiveEconomicZone { get; set; }
    [BsonElement("Exclusive fishing zone")]
    public ExclusiveFishingZone? ExclusiveFishingZone { get; set; }
    [BsonElement("Territorial sea")]
    public TerritorialSea? TerritorialSea { get; set; }
}

/// <summary>
/// ContiguousZone is a submodel of MaritimeClaims model.
/// </summary>
public class ContiguousZone: TextEntity{}

/// <summary>
/// ContiguousShelf is a submodel of MaritimeClaims model.
/// </summary>
public class ContiguousShelf: TextEntity{}

/// <summary>
/// ExclusiveEconomicZone is a submodel of MaritimeClaims model.
/// </summary>
public class ExclusiveEconomicZone: TextEntity{}

/// <summary>
/// ExclusiveFishingZone is a submodel of MaritimeClaims model.
/// </summary>
public class ExclusiveFishingZone: TextEntity{}

/// <summary>
/// TerritorialSea is a submodel of MaritimeClaims model.
/// </summary>
public class TerritorialSea: TextEntity{}