namespace CompareCountries.Core.Domain.WorldFactbook;

public class Transportation: BaseEntity
{
    public string? NationalAirTransportSystem { get; set; }
    public string? CivilAircraftRegistrationCountryCodePrefix { get; set; }
    public string? Airports { get; set; }
    public string? AirportsWithPavedRunways { get; set; }
    public string? AirportsWithUnpavedRunways { get; set; }
    public string? Heliports { get; set; }
    public string? Pipelines { get; set; }
    public string? Roadways { get; set; }
    public string? Railways { get; set; }
    public string? Waterways { get; set; }
    public string? MerchantMarine { get; set; }
    public string? PortsAndTerminals { get; set; }
}