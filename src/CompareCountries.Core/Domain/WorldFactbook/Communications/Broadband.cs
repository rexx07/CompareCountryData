using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Communications;

/// <summary>
/// Broadband is a submodel of communications model
/// </summary>
public class Broadband
{
    [BsonElement("Subscription per 100 inhabitants")]
    public SubscriptionPerIndividuals SubscriptionPerIndividuals { get; set; }
    [BsonElement("Total Subscribers")]
    public BroadbandTotal Total { get; set; }
}

/// <summary>
/// SubscriptionPerIndividuals is a submodel of Broadband model
/// </summary>
public class SubscriptionPerIndividuals: TextEntity { }

/// <summary>
/// BroadbandTotal is a submodel of Broadband model
/// </summary>
public class BroadbandTotal: TextEntity { }