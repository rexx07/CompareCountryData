namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// Economy Entity model for economy and its subcategories.
/// </summary>
public class Economy
{
    public string? EconomicOverview { get; set; }
    public string? RealGdpPurchasingPowerParity { get; set; }
    public string? RealGdpGrowthRate { get; set; }
    public string? RealGdpPerCapita { get; set; }
    public string? InflationRateConsumerPrices { get; set; }
    public string? CreditRatings { get; set; }
    public string? GdpCompositionBySectorOfOrigin { get; set; }
    public string? GdpCompositionByEndUse { get; set; }
    public string? AgriculturalProducts { get; set; }
    public string? Industries { get; set; }
    public string? IndustrialProductionGrowthRate { get; set; }
    public string? LaborForce { get; set; }
    public string? LaborForceByOccupation { get; set; }
    public string? UnemploymentRate { get; set; }
    public string? UnemploymentYouthAges15To24 { get; set; }
    public string? PopulationBelowPovertyLine { get; set; }
    public string? GiniIndexCoefficientDistributionOfFamilyIncome { get; set; }
    public string? HouseholdIncomeOrConsumptionByPercentageShare { get; set; }
    public string? Budget { get; set; }
    public string? BudgetSurplus { get; set; }
    public string? PublicDebt { get; set; }
    public string? TaxesAndOtherRevenues { get; set; }
    public string? FiscalYear { get; set; }
    public string? CurrentAccountBalance { get; set; }
    public string? ExportsPartners { get; set; }
    public string? ExportsCommodities { get; set; }
    public string? Imports { get; set; }
    public string? ImportsPartners { get; set; }
    public string? ImportsCommodities { get; set; }
    public string? ReservesOfForeignExchangeAndGold { get; set; }
    public string? DebtExternal { get; set; }
    public string? ExchangeRates { get; set; }
}