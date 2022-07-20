using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environments;

/// <summary>
///     AirPollutants is a submodel of Environment model.
/// </summary>
public class AirPollutants
{
    [BsonElement("Carbon dioxide emissions")]
    public CO2Emissions? Co2Emissions { get; set; }

    [BsonElement("Methane emissions")] public MethaneEmissions? MethaneEmissions { get; set; }

    [BsonElement("Particulate matter emissions")]
    public ParticulateMatterEmissions? ParticulateMatterEmissions { get; set; }
}

/// <summary>
///     CO2Emissions is a submodel of Environment model.
/// </summary>
public class CO2Emissions : TextEntity
{
}

/// <summary>
///     MethaneEmissions is a submodel of Environment model.
/// </summary>
public class MethaneEmissions : TextEntity
{
}

/// <summary>
///     ParticulateMatterEmission is a submodel of Environment model.
/// </summary>
public class ParticulateMatterEmissions : TextEntity
{
}