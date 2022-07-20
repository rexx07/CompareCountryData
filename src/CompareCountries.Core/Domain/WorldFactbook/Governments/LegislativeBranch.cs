using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     LegislativeBranch is a submodel of Government model.
/// </summary>
public class LegislativeBranch : ExtraNote
{
    [BsonElement("Description")] public Description? Description { get; set; }

    [BsonElement("Election results")] public LbElectionResults? LbElectionResults { get; set; }

    [BsonElement("Elections")] public Elections? Elections { get; set; }
}

/// <summary>
///     Description is a submodel of LegislativeBranch model.
/// </summary>
public class Description : TextEntity
{
}

/// <summary>
///     LbElectionResults is a submodel of LegislativeBranch model.
/// </summary>
public class LbElectionResults : TextEntity
{
}

/// <summary>
///     Elections is a submodel of LegislativeBranch model.
/// </summary>
public class Elections : TextEntity
{
}