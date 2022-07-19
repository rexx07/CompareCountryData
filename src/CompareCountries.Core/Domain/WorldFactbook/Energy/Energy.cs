using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Energy;

public class Energy: BaseEntity
{
    [BsonElement("Crude oil - exports")]
    public CrudeOilExports? CrudeOilExports { get; set; }
    [BsonElement("Crude oil - imports")]
    public CrudeOilImports? CrudeOilImports { get; set; }
    [BsonElement("Crude oil - production")]
    public CrudeOilProduction? CrudeOilProduction { get; set; }
    [BsonElement("Crude oil - proved reserves")]
    public CrudeOilProvedReserves? CrudeOilProvedReserves { get; set; }
    [BsonElement("Electricity - consumption")]
    public ElectricityConsumption? ElectricityConsumption { get; set; }
    [BsonElement("Electricity - exports")]
    public ElectricityExports? ElectricityExports { get; set; }
    [BsonElement("Electricity - from fossil fuels")]
    public ElectricityFromFossilFuels? ElectricityInstalledFromFossilFuels { get; set; }
    [BsonElement("Electricity - from hydroelectric plants")]
    public ElectricityFromHydroelectricPlants? ElectricityFromHydroelectricPlants { get; set; }
    [BsonElement("Electricity - from nuclear fuels")]
    public ElectricityFromNuclearFuels? ElectricityFromNuclear { get; set; }
    [BsonElement("Electricity - from other renewable resources")]
    public ElectricityFromRenewableSources? ElectricityFromRenewableSources { get; set; }
    [BsonElement("Electricity - imports")]
    public ElectricityImports? CrudeElectricityImports { get; set; }
    [BsonElement("Electricity - installed generating capacity")]
    public ElectricityInstalledGeneratingCapacity? ElectricityInstalledGenerating { get; set; }
    [BsonElement("Electricity - production")]
    public ElectricityProduction? ElectricityProduction { get; set; }
    [BsonElement("Electricity - Access")]
    public ElectricityAccess? ElectricityAccess { get; set; }
    [BsonElement("Natural gas - consumption")]
    public NaturalGasConsumption? NaturalGasConsumption { get; set; }
    [BsonElement("Natural gas - exports")]
    public NaturalGasExports? NaturalGasExports { get; set; }
    [BsonElement("Natural gas - imports")]
    public NaturalGasImports? NaturalGasImports { get; set; }
    [BsonElement("Natural gas - production")]
    public NaturalGasProduction? NaturalGasProduction { get; set; }
    [BsonElement("Natural gas - proved reserves")]
    public NaturalGasProvedReserves? NaturalGasProvedReserves { get; set; }
    [BsonElement("Refined petroleum products - consumption")]
    public RefinedPetroleumProductsConsumption? RefinedPetroleumProductsConsumption { get; set; }
    [BsonElement("Refined petroleum products - exports")]
    public RefinedPetroleumProductsExports? RefinedPetroleumProductsExports { get; set; }
    [BsonElement("Refined petroleum products - imports")]
    public RefinedPetroleumProductsImports? TRefinedPetroleumProductsImports { get; set; }
    [BsonElement("Refined petroleum products - production")]
    public RefinedPetroleumProductsProduction? NatuRefinedPetroleumProductsProduction { get; set; }
}