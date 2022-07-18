using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Communications;

/// <summary>
/// TelephonesMobile is a submodel under communications models
/// </summary>
public class TelephonesMobile
{
    [BsonElement("Subscriptions Per 100 inhabitants for mobile")]
    public SubPer100InhabitantsMobile SubPer100InhabitantsMobile { get; set; }
    [BsonElement("Total subscriptions for mobile")]
    public TotalSubscriptionsMobile TotalSubscriptionsMobile { get; set; }
}

/// <summary>
/// SubPer100InhabitantsMobile is a submodel under communications models
/// </summary>
public class SubPer100InhabitantsMobile: TextEntity{}

/// <summary>
/// TotalSubscriptionsMobile is a submodel under communications models
/// </summary>
public class TotalSubscriptionsMobile: TextEntity{}