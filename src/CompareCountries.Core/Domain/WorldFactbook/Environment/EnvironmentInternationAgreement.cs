using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environment;

/// <summary>
///     EnvironmentInternationAgreement is a submodel of Environment model.
/// </summary>
public class EnvironmentInternationAgreement
{
    [BsonElement("Party to")] public PartyTo? PartyTo { get; set; }

    [BsonElement("Signed, but not ratified")]
    public SignedNotRatified? SignedNotRatified { get; set; }
}

/// <summary>
///     PartyTo is a submodel of Environment model.
/// </summary>
public class PartyTo : TextEntity
{
}

/// <summary>
///     SignedNotRatified is a submodel of Environment model.
/// </summary>
public class SignedNotRatified : TextEntity
{
}