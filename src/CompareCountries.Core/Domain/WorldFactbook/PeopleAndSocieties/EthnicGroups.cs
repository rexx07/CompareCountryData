using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     EthnicGroups is a submodel of PeopleAndSociety model.
/// </summary>
public class EthnicGroups : ExtraNote
{
    [BsonElement("text")] public EthnicGroupsText? EthnicGroupsText { get; set; }
}

/// <summary>
///     EthnicGroupsText is a submodel of EthnicGroups model.
/// </summary>
public class EthnicGroupsText : TextEntity
{
}