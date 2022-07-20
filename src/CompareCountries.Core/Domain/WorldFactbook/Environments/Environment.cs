using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environments;

public class Environment : BaseEntity
{
    [BsonElement("Air Pollutants")] public AirPollutants? AirPollutants { get; set; }

    [BsonElement("Climate")] public Climate? Climate { get; set; }

    [BsonElement("Environment - international agreement")]
    public EnvironmentCurrentIssues? AirPolEnvironmentCurrentIssues { get; set; }

    [BsonElement("Environment international agreements")]
    public EnvironmentInternationAgreement? EnvironmentInternationAgreement { get; set; }

    [BsonElement("Food insecurity")] public FoodInsecurity? FoodInsecurity { get; set; }

    [BsonElement("Land use")] public LandUse? LandUse { get; set; }

    [BsonElement("Major aquifers")] public MajorAquifers? MajorAquifers { get; set; }

    [BsonElement("Major infectious diseases")]
    public MajorInfectiousDiseases? MajorInfectiousDiseases { get; set; }

    [BsonElement("Major lakes (area sq km)")]
    public MajorLakes? MajorLakes { get; set; }

    [BsonElement("Major Rivers (by length in km)")]
    public MajorRivers? MajorRivers { get; set; }

    [BsonElement("Major watersheds (area sq km)")]
    public MajorWatersheds? MajorWatersheds { get; set; }

    [BsonElement("Revenue from coal")] public RevenueFromCoal? RevenueFromCoal { get; set; }

    [BsonElement("Revenue from forest resources")]
    public RevenueFromForestResources? RevenueFromForestResources { get; set; }

    [BsonElement("Total renewable water resources")]
    public TotalRenewableWaterResources? TotalRenewableWaterResources { get; set; }

    [BsonElement("Total water withdrawal")]
    public TotalWaterWithdrawal? TotalWaterWithdrawal { get; set; }

    [BsonElement("Urbanization")] public Urbanization? Urbanization { get; set; }

    [BsonElement("Waste and recycling")] public WasteAndRecycling? WasteAndRecycling { get; set; }
}