using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// PoliticalParties is a submodel of Government model.
/// </summary>
public class PoliticalPartiesAndLeaders: MetaData
{
    [BsonElement("Political Parties And Leaders")]
    public PoliticalPartiesAndLeadersNotes? PoliticalPartiesAndLeadersNotes { get; set; }
}

/// <summary>
/// PoliticalPartiesAndLeadersNotes is a submodel of PoliticalPartiesAndLeaders model.
/// </summary>
public class PoliticalPartiesAndLeadersNotes: TextEntity{}