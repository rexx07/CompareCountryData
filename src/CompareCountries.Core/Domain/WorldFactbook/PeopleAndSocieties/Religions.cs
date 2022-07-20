using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     Religion is a submodel of PeopleAndSociety model.
/// </summary>
public class Religions : ExtraNote
{
    [BsonElement("text")] public ReligionText? ReligionText { get; set; }
}

/// <summary>
///     ReligionText is a submodel of Religion model.
/// </summary>
public class ReligionText : TextEntity
{
}