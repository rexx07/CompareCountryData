using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Energies;

/// <summary>
///     ElectricityAccess is a submodel of Energy model.
/// </summary>
public class ElectricityAccess
{
    [BsonElement("Electrification - rural areas")]
    public ElectrificationRuralAreas ElectrificationRuralAreas { get; set; }

    [BsonElement("Electrification - total population")]
    public ElectrificationTotalPopulation LElectrificationTotalPopulation { get; set; }

    [BsonElement("Electrification - urban areas")]
    public ElectrificationUrbanAreas ElectrificationUrbanAreas { get; set; }
}

/// <summary>
///     ElectrificationRuralAreas is a submodel of ElectricityAccess model.
/// </summary>
public class ElectrificationRuralAreas : TextEntity
{
}

/// <summary>
///     ElectrificationTotalPopulation is a submodel of ElectricityAccess model.
/// </summary>
public class ElectrificationTotalPopulation : TextEntity
{
}

/// <summary>
///     ElectrificationUrbanAreas is a submodel of ElectricityAccess model.
/// </summary>
public class ElectrificationUrbanAreas : TextEntity
{
}