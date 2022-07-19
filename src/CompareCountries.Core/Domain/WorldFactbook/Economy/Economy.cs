using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// Economy Entity model for economy and its subcategories.
/// </summary>
public class Economy
{
    [BsonElement("Agricultural products")]
    public AgriculturalProducts? AgriculturalProducts { get; set; }
    [BsonElement("Budget")]
    public Budget? Budget { get; set; }
    [BsonElement("Budget surplus (+) or deficit(-)")]
    public BudgetSurplus? BudgetSurplus { get; set; }
    [BsonElement("Credit ratings")]
    public CreditRatings? CreditRatings { get; set; }
    [BsonElement("Current account balance")]
    public CurrentAccountBalance? CurrentAccountBalance { get; set; }
    [BsonElement("Debt - external")]
    public DebtExternal? DebtExternal { get; set; }
    [BsonElement("Economic overview")]
    public EconomicOverview? EconomicOverview { get; set; }
    [BsonElement("Exchange rate")]
    public ExchangeRates? ExchangeRates { get; set; }
    [BsonElement("Exports")]
    public Exports? Exports { get; set; }
    [BsonElement("Exports - commodities")]
    public ExportsCommodities? ExportsCommodities { get; set; }
    [BsonElement("Export - partners")]
    public ExportsPartners? ExportsPartners { get; set; }
    [BsonElement("Fiscal year")]
    public FiscalYear? FiscalYear { get; set; }
    [BsonElement("GDP (official exchange rate)")]
    public Gdp? Gdp { get; set; }
    [BsonElement("GDP - composition, by end use")]
    public GdpCompositionEndUse? GdpCompositionEndUse { get; set; }
    [BsonElement("Gdp - composition, by sector of origin")]
    public GdpCompositionBySector? GdpCompositionBySector { get; set; }
    [BsonElement("Gini index coefficient - distribution of family income")]
    public GiniIndexCoefficient? GiniIndexCoefficient { get; set; }
    [BsonElement("Household income of consumption by percentage share")]
    public HouseholdIncomeConsumption? HouseholdIncomeConsumption { get; set; }
    [BsonElement("Imports")]
    public Imports? Imports { get; set; }
    [BsonElement("Imports - commodities")]
    public ImportsCommodities? ImportsCommodities { get; set; }
    [BsonElement("Import - partners")]
    public ImportsPartners? ImportsPartners { get; set; }
    [BsonElement("Industrial production growth rate")]
    public IndustrialProductionGrowthRate? IndustrialProductionGrowthRate { get; set; }
    [BsonElement("Industries")]
    public Industries? Industries { get; set; }
    [BsonElement("Inflation rate (consumer prices)")]
    public InflationRate? InflationRate { get; set; }
    [BsonElement("Labor - force")]
    public LaborForce? LaborForce { get; set; }
    [BsonElement("Labor - force by occupation")]
    public LaborForceByOccupation? LaborForceByOccupation { get; set; }
    [BsonElement("Population below poverty line")]
    public PopulationBPL? PopulationBpl { get; set; }
    [BsonElement("Public debt")]
    public PublicDebt? PublicDebt { get; set; }
    [BsonElement("Real GDP (purchasing power parity")]
    public RealGdpPPP? RealGdpPpp { get; set; }
    [BsonElement("Real GDP growth rate")]
    public RealGdpGR RealGdpGr { get; set; }
    [BsonElement("Real GDP per capita")]
    public RealGdpPC? RealGdpPc { get; set; }
    [BsonElement("Reserves of foreign exchange and gold")]
    public ReservesOfFxGld? ReservesOfFxGld { get; set; }
    [BsonElement("Taxes and other revenue")]
    public TaxesAndRev? TaxesAndRev { get; set; }
    [BsonElement("Unemployment rate")]
    public UnemploymentRate? UnemploymentRate { get; set; }
    [BsonElement("Unemployment, youth ages 15-24")]
    public UnemployedYouth? UnemployedYouth { get; set; }
}