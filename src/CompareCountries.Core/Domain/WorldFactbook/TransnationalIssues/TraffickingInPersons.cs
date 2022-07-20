using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.TransnationalIssues;

/// <summary>
///     TraffickingInPersons is a submodel of TransnationalIssues model.
/// </summary>
public class TraffickingInPersons
{
    [BsonElement("Current situation")] public CurrentSituation? CurrentSituation { get; set; }

    [BsonElement("Tier rating")] public TierRating? TierRating { get; set; }
}

/// <summary>
///     CurrentSituation is a submodel of TraffickingInPersons model.
/// </summary>
public class CurrentSituation : TextEntity
{
}

/// <summary>
///     TierRating is a submodel of TraffickingInPersons model.
/// </summary>
public class TierRating : TextEntity
{
}