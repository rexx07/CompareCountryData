using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.MilitariesAndSecurities;

public class MilitaryAndSecurity : BaseEntity
{
    [BsonElement("Maritime threats")] public MaritimeThreats? MaritimeThreats { get; set; }

    [BsonElement("Military - note")] public MilitaryNote? MilitaryNote { get; set; }

    [BsonElement("Military and security forces")]
    public MilitaryAndSecurityForces? MilitaryAndSecurityForces { get; set; }

    [BsonElement("Military and security service personnel strengths")]
    public MltaryAndSecSrvcsPrsnelStrgth? MltaryAndSecSrvcsPrsnelStrgth { get; set; }

    [BsonElement("Military deployments")] public MilitaryDeployments? MilitaryDeployments { get; set; }

    [BsonElement("Military equipment inventories and acquisitions")]
    public MltaryEquipInvAndAcqui? MltaryEquipInvAndAcqui { get; set; }

    [BsonElement("Military expenditures")] public MilitaryExpenditures? MilitaryExpenditures { get; set; }

    [BsonElement("Military service age and obligation")]
    public MltarySrvcAgeAndObligation? MltarySrvcAgeAndObligation { get; set; }
}