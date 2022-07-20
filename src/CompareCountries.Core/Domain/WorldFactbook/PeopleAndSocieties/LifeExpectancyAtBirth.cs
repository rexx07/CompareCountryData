using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     LifeExpectancyAtBirth is a submodel of PeopleAndSociety model.
/// </summary>
public class LifeExpectancyAtBirth
{
    [BsonElement("female")] public FemaleInfantMortalityRate? FemaleInfantMortalityRate { get; set; }

    [BsonElement("Male")] public MaleInfantMortalityRate? MaleInfantMortalityRate { get; set; }

    [BsonElement("total")] public TotalPopulation? TotalPopulation { get; set; }
}

/// <summary>
///     FemaleLifeExpectancyAtBirth is a submodel of LifeExpectancyAtBirth model.
/// </summary>
public class FemaleLifeExpectancyAtBirth : TextEntity
{
}

/// <summary>
///     MaleLifeExpectancyAtBirth is a submodel of LifeExpectancyAtBirth model.
/// </summary>
public class MaleLifeExpectancyAtBirth : TextEntity
{
}

/// <summary>
///     TotalPopulation is a submodel of LifeExpectancyAtBirth model.
/// </summary>
public class TotalPopulation : TextEntity
{
}