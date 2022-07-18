namespace CompareCountries.Core.Domain.WorldFactbook;

public class Energy: BaseEntity
{
    public string? ElectricityAccess { get; set; }
    public string? ElectricityProduction { get; set; }
    public string? ElectricityConsumption { get; set; }
    public string? ElectricityExports { get; set; }
    public string? ElectricityImports { get; set; }
    public string? ElectricityInstalledGeneratingCapacity { get; set; }
    public string? ElectricityInstalledFromFossilFuels { get; set; }
    public string? ElectricityInstalledFromNuclearFuels { get; set; }
    public string? ElectricityInstalledFromHydroElectricPlants { get; set; }
    public string? ElectricityInstalledFromOtherRenewableResources { get; set; }
    public string? CrudeOilProduction { get; set; }
    public string? CrudeOilExports { get; set; }
    public string? CrudeOilImports { get; set; }
    public string? CrudeOilProvedReserves { get; set; }
    public string? RefinedPetroleumProductsProduction { get; set; }
    public string? RefinedPetroleumProductsConsumption { get; set; }
    public string? RefinedPetroleumProductsExports { get; set; }
    public string? RefinedPetroleumProductsImports { get; set; }
    public string? NaturalGasProduction { get; set; }
    public string? NaturalGasConsumption { get; set; }
    public string? NaturalGasExports { get; set; }
    public string? NaturalGasImports { get; set; }
    public string? NaturalGasProvedReserves { get; set; }
    public string? DeathRate { get; set; }
}