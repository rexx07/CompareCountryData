using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     Languages is a submodel of PeopleAndSociety model.
/// </summary>
public class Languages : ExtraNote
{
    [BsonElement("Languages")] public AllLanguages? AllLanguages { get; set; }

    [BsonElement("Major-languages samples(s)")]
    public MajorLanguageSamples? MajorLanguageSamples { get; set; }

    [BsonElement("text")] public LanguagesText? LanguagesText { get; set; }
}

/// <summary>
///     AllLanguages is a submodel of Languages model.
/// </summary>
public class AllLanguages : TextEntity
{
}

/// <summary>
///     MajorLanguageSamples is a submodel of Languages model.
/// </summary>
public class MajorLanguageSamples : TextEntity
{
}

/// <summary>
///     LanguagesText is a submodel of Languages model.
/// </summary>
public class LanguagesText : TextEntity
{
}