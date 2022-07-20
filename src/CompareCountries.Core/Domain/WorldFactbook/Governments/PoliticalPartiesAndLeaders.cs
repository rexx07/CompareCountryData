using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     PoliticalPartiesAndLeaders is a submodel of Government model.
/// </summary>
public class PoliticalPartiesAndLeaders : ExtraNote
{
    [BsonElement("text")] public PoliticalPartiesAndLeadersText? PoliticalPartiesAndLeadersText { get; set; }
}

/// <summary>
///     PoliticalPartiesAndLeadersText is a submodel of PoliticalPartiesAndLeaders model.
/// </summary>
public class PoliticalPartiesAndLeadersText : TextEntity
{
}