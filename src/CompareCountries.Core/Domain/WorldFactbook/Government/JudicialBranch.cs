using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// JudicialBranch is a submodel of Government model.
/// </summary>
public class JudicialBranch: MetaData
{
    [BsonElement("Highest courts")]
    public HighestCourts? HighestCourts { get; set; }
    [BsonElement("Judge selection and term of office")]
    public JudgeSelectnAndTrmsOfOffice? JudgeSelectnAndTrmsOfOffice { get; set; }
    [BsonElement("Subordinate courts")]
    public SubordinateCourts? SubordinateCourts { get; set; }
}

/// <summary>
/// HighestCourts is a submodel of JudicialBranch model.
/// </summary>
public class HighestCourts: TextEntity{}

/// <summary>
/// JudgeSelectnAndTrmsOfOffice is a submodel of JudicialBranch model.
/// </summary>
public class JudgeSelectnAndTrmsOfOffice: TextEntity{}

/// <summary>
/// SubordinateCourts is a submodel of JudicialBranch model.
/// </summary>
public class SubordinateCourts: TextEntity{}
