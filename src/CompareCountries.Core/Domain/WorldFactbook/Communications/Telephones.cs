using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Communications;

/// <summary>
/// Telephones is a submodel under communications models
/// </summary>
public class Telephones
{
    [BsonElement("Subscription Per 100 inhabitants")]
    public SubPer100Inhabitants SubPer100Inhabitants { get; set; }
    [BsonElement("Total number of subscriptions")]
    public TotalSubscriptions TotalSubscriptions { get; set; }
}

/// <summary>
/// SubPer100Inhabitants is a submodel under Telephones models
/// </summary>
public class SubPer100Inhabitants: TextEntity{}

/// <summary>
/// TotalSubscriptions is a submodel under Telephones models
/// </summary>
public class TotalSubscriptions: TextEntity{}
