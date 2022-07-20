using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.MilitariesAndSecurities;

/// <summary>
///     MilitaryAndSecurityForces is a submodel of MilitaryAndSecurity model.
/// </summary>
public class MilitaryAndSecurityForces : ExtraNote
{
    [BsonElement("Text")] public MilitaryAndSecurityForcesText? MilitaryAndSecurityForcesText { get; set; }
}

/// <summary>
///     MilitaryAndSecurityForcesText is a submodel of MilitaryAndSecurity model.
/// </summary>
public class MilitaryAndSecurityForcesText : TextEntity
{
}