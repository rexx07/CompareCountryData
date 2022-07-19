using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// ExecutiveBranch is a submodel of Government model.
/// </summary>
public class ExecutiveBranch: MetaData
{
    [BsonElement("Cabinet")]
    public Cabinet? Cabinet { get; set; }
    [BsonElement("Chief of state")]
    public ChiefOfState? ChiefOfState { get; set; }
    [BsonElement("Election results")]
    public EbElectionResults? ElectionResults { get; set; }
    [BsonElement("Elections/appointments")]
    public ElectionsAppointments? ElectionsAppointments { get; set; }
    [BsonElement("Head of government")]
    public HeadOfGovernment? HeadOfGovernment { get; set; }
}

/// <summary>
/// Cabinet is a submodel of ExecutiveBranch model.
/// </summary>
public class Cabinet: TextEntity{}

/// <summary>
/// ChiefOfState is a submodel of ExecutiveBranch model.
/// </summary>
public class ChiefOfState: TextEntity{}

/// <summary>
/// EbElectionResults is a submodel of ExecutiveBranch model.
/// </summary>
public class EbElectionResults: TextEntity{}

/// <summary>
/// ElectionsAppointment is a submodel of ExecutiveBranch model.
/// </summary>
public class ElectionsAppointments: TextEntity{}

/// <summary>
/// HeadOfGovernment is a submodel of ExecutiveBranch model.
/// </summary>
public class HeadOfGovernment: TextEntity{}