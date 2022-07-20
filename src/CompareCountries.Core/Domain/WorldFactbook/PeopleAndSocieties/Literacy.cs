using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     Literacy is a submodel of PeopleAndPopulation model.
/// </summary>
public class Literacy
{
    [BsonElement("Definition")] public Definition? Definition { get; set; }

    [BsonElement("Female")] public FemaleLiteracy? FemaleLiteracy { get; set; }

    [BsonElement("Male")] public MaleLiteracy? MaleLiteracy { get; set; }

    [BsonElement("Total population")] public LiterateTotalPopulation? LiterateTotalPopulation { get; set; }
}

/// <summary>
///     Definition is a submodel of Literacy model.
/// </summary>
public class Definition : TextEntity
{
}

/// <summary>
///     FemaleLiteracy is a submodel of Literacy model.
/// </summary>
public class FemaleLiteracy : TextEntity
{
}

/// <summary>
///     MaleLiteracy is a submodel of Literacy model.
/// </summary>
public class MaleLiteracy : TextEntity
{
}

/// <summary>
///     LiterateTotalPopulation is a submodel of Literacy model.
/// </summary>
public class LiterateTotalPopulation : TextEntity
{
}