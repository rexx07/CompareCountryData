using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     Nationality is a submodel of PeopleAndSociety model.
/// </summary>
public class Nationality
{
    [BsonElement("Adjective")] public Adjective? Adjective { get; set; }

    [BsonElement("Noun")] public Noun? Noun { get; set; }
}

/// <summary>
///     Adjective is a submodel of Nationality model.
/// </summary>
public class Adjective : TextEntity
{
}

/// <summary>
///     Noun is a submodel of Nationality model.
/// </summary>
public class Noun : TextEntity
{
}