using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     InfantMortalityRate is a submodel of PeopleAndSociety model.
/// </summary>
public class InfantMortalityRate
{
    [BsonElement("female")] public FemaleInfantMortalityRate? FemaleInfantMortalityRate { get; set; }

    [BsonElement("Male")] public MaleInfantMortalityRate? MaleInfantMortalityRate { get; set; }

    [BsonElement("total")] public InfantMortalityRateTotal? InfantMortalityRateTotal { get; set; }
}

/// <summary>
///     FemaleInfantMortalityRate is a submodel of InfantMortalityRate model.
/// </summary>
public class FemaleInfantMortalityRate : TextEntity
{
}

/// <summary>
///     MaleInfantMortalityRate is a submodel of InfantMortalityRate model.
/// </summary>
public class MaleInfantMortalityRate : TextEntity
{
}

/// <summary>
///     InfantMortalityRateTotal is a submodel of InfantMortalityRate model.
/// </summary>
public class InfantMortalityRateTotal : TextEntity
{
}