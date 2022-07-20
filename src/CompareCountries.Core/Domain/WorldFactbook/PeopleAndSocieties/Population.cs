using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     Population is a submodel of PeopleAndSociety model.
/// </summary>
public class Population : ExtraNote
{
    [BsonElement("text")] public PopulationText? PopulationText { get; set; }
}

/// <summary>
///     populationText is a submodel of Population
/// </summary>
public class PopulationText : TextEntity
{
}