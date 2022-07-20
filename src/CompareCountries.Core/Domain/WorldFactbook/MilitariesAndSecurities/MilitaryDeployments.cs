using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.MilitariesAndSecurities;

/// <summary>
///     MilitaryDeployments is a submodel of MilitaryAndSecurity model.
/// </summary>
public class MilitaryDeployments : ExtraNote
{
    [BsonElement("text")] public MilitaryDeploymentText? MilitaryAndSecurityForcesText { get; set; }
}

/// <summary>
///     MilitaryDeploymentText is a submodel of MilitaryAndSecurity model.
/// </summary>
public class MilitaryDeploymentText : TextEntity
{
}