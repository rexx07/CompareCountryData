namespace CompareCountries.Core.Domain.WorldFactbook;

public class Environment : BaseEntity
{
    public string? EnvironmentCurrentIssues { get; set; }
    public string? EnvironmentInternationalAgreements { get; set; }
    public string? AirPollutions { get; set; }
    public string? Climate { get; set; }
    public string? LandUse { get; set; }
    public string? Urbanization { get; set; }
    public string? RevenueFromForesResources { get; set; }
    public string? RevenueFromCoal { get; set; }
    public string? MajorInfectiousDiseases { get; set; }
    public string? FoodInsecurity { get; set; }
    public string? MajorLakesAreaSqKm { get; set; }
    public string? MajorRiversByLengthInKm { get; set; }
    public string? WasteAndRecycling { get; set; }
    public string? MajorWaterShedsAreaSqKm { get; set; }
    public string? MajorAquifers { get; set; }
    public string? TotalWaterWithdrawal { get; set; }
    public string? TotalRenewableWaterResources { get; set; }
}