using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.MilitariesAndSecurities;

/// <summary>
///     MltarySrvcAgeAndObligation is a submodel of MilitaryAndSecurity model.
/// </summary>
[DisplayName("Military service age and obligation")]
public class MltarySrvcAgeAndObligation : ExtraNote
{
    [BsonElement("text")] public MltarySrvcAgeAndObligationText? MilitaryAndDeploymentText { get; set; }
}

/// <summary>
///     MltarySrvcAgeAndObligationText is a submodel of MltarySrvcAgeAndObligation model.
/// </summary>
public class MltarySrvcAgeAndObligationText : TextEntity
{
}