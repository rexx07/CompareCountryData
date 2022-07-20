using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     MajorInfectiousDiseases is a submodel of PeopleAndSociety model.
/// </summary>
public class MajorInfectiousDiseases : ExtraNote
{
    [BsonElement("Animal contact diseases")]
    public AnimalContactDiseases? AnimalContactDiseases { get; set; }

    [BsonElement("Degree of risk")] public DegreeOfRisk? DegreeOfRisk { get; set; }

    [BsonElement("Food and waterborne diseases")]
    public FoodOrWaterborneDiseases? AnOrWaterborneDiseases { get; set; }

    [BsonElement("Respiratory diseases")] public RespiratoryDiseases? RespiratoryDiseases { get; set; }

    [BsonElement("Vectorborne diseases")] public VectorborneDiseases? VectorborneDiseases { get; set; }

    [BsonElement("Water contact diseases")]
    public WaterContactDiseases? WaterContactDiseases { get; set; }
}

/// <summary>
///     AnimalContactDiseases is a submodel of MajorInfectiousDiseases model.
/// </summary>
public class AnimalContactDiseases : TextEntity
{
}

/// <summary>
///     AnimalCDegreeOfRiskontactDiseases is a submodel of MajorInfectiousDiseases model.
/// </summary>
public class DegreeOfRisk : TextEntity
{
}

/// <summary>
///     FoodOrWaterborneDiseases is a submodel of MajorInfectiousDiseases model.
/// </summary>
public class FoodOrWaterborneDiseases : TextEntity
{
}

/// <summary>
///     RespiratoryDiseases is a submodel of MajorInfectiousDiseases model.
/// </summary>
public class RespiratoryDiseases : TextEntity
{
}

/// <summary>
///     VectorborneDiseases is a submodel of MajorInfectiousDiseases model.
/// </summary>
public class VectorborneDiseases : TextEntity
{
}

/// <summary>
///     WaterContactDiseases is a submodel of MajorInfectiousDiseases model.
/// </summary>
public class WaterContactDiseases : TextEntity
{
}