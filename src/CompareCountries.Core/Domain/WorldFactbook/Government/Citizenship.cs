using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// Citizenship is a submodel of Government model.
/// </summary>
public class Citizenship
{
    [BsonElement("Citizenship by birth")]
    public CitizenByBirth? CitizenByBirth { get; set; }
    [BsonElement("Citizenship by descent only")]
    public CitizenByDescentOnly? CitizenByDescentOnly { get; set; }
    [BsonElement("dual Citizenship recognized")]
    public DualCitizenshipRecognized? DualCitizenshipRecognized { get; set; }
    [BsonElement("Residency Requirement for naturalization")]
    public ResidencyRqForNaturaliztn? ResidencyRqForNaturaliztn { get; set; }
}

/// <summary>
/// CitizenByBirth is a submodel of Citizenship model.
/// </summary>
public class CitizenByBirth: TextEntity{}

/// <summary>
/// CitizenByDescentOnly is a submodel of Citizenship model.
/// </summary>
public class CitizenByDescentOnly: TextEntity{}

/// <summary>
/// DualCitizenshipRecognized is a submodel of Citizenship model.
/// </summary>
public class DualCitizenshipRecognized: TextEntity{}

/// <summary>
/// ResidencyRqForNaturaliztn is a submodel of Citizenship model.
/// </summary>
public class ResidencyRqForNaturaliztn: TextEntity{}