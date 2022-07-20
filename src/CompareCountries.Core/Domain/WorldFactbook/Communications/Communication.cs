using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Communications;

/// <summary>
///     Communications Entity model for communications and its subcategories
/// </summary>
public class Communication
{
    [BsonElement("Broadband - fixed subscriptions")]
    public Broadband? Broadband { get; set; }

    [BsonElement("Broadcast media")] public BroadcastMedia? BroadcastMedia { get; set; }

    [BsonElement("Internet country code")] public InternetCountryCode? InternetCountryCode { get; set; }

    [BsonElement("Internet users")] public InternetUsers? InternetUsers { get; set; }

    [BsonElement("Telecommunications systems")]
    public TelecommunicationsSystems? TelecommunicationsSystems { get; set; }

    [BsonElement("Telephones fixed lines")]
    public Telephones? Telephones { get; set; }

    [BsonElement("Telephones - mobile cellular")]
    public TelephonesMobile? TelephonesMobile { get; set; }
}