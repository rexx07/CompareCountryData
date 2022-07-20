using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     MedianAge is a submodel of PeopleAndPopulation model.
/// </summary>
public class MedianAge
{
    [BsonElement("female")] public FemaleMedianAge? FemaleMedianAge { get; set; }

    [BsonElement("Male")] public MaleMedianAge? MaleMedianAge { get; set; }

    [BsonElement("total")] public MedianAgeTotal? MedianAgeTotal { get; set; }
}

/// <summary>
///     FemaleMedianAge is a submodel of MedianAge model.
/// </summary>
public class FemaleMedianAge : TextEntity
{
}

/// <summary>
///     MaleMedianAge is a submodel of MedianAge model.
/// </summary>
public class MaleMedianAge : TextEntity
{
}

/// <summary>
///     MedianAgeTotal is a submodel of MedianAge model.
/// </summary>
public class MedianAgeTotal : TextEntity
{
}