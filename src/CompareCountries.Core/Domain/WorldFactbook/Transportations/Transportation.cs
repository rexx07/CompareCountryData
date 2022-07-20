using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

public class Transportation : BaseEntity
{
    [BsonElement("Airports")] public Airports? Airports { get; set; }

    [BsonElement("Airports - with paved runways")]
    public AirprtsWithPvdRunways? AirprtsWithPvdRunways { get; set; }

    [BsonElement("Airports - with unpaved runways")]
    public AirprtsWithUnpvdRunways? AirprtsWithUnpvdRunways { get; set; }

    [BsonElement("Civil aircraft registration country code prefix")]
    public CivilAcrftRegCountryCode? CivilAcrftRegCountryCode { get; set; }

    [BsonElement("Heliports")] public Heliports? Heliports { get; set; }

    [BsonElement("Merchant marine")] public MerchantMarine? MerchantMarine { get; set; }

    [BsonElement("National air transport system")]
    public NationalAirTransportSystem? NationalAirTransportSystem { get; set; }

    [BsonElement("Pipelines")] public Pipelines? Pipelines { get; set; }

    [BsonElement("Ports and terminals")] public PortsAndTerminals? PortsAndTerminals { get; set; }

    [BsonElement("Railways")] public Railways? Railways { get; set; }

    [BsonElement("Roadways")] public Roadways? Roadways { get; set; }

    [BsonElement("Waterways")] public WaterWays? WaterWays { get; set; }
}