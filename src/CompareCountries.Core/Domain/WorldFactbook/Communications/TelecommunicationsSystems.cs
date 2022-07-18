namespace CompareCountries.Core.Domain.WorldFactbook.Communications;

/// <summary>
/// a submodel under communications model
/// </summary>
public class TelecommunicationsSystems: MetaData
{
    public Domestic Domestic { get; set; }
    public GeneralAssessment GeneralAssessment { get; set; }
    public International International { get; set; }
}

/// <summary>
/// Domestic is a submodel under Telecoommunications model
/// </summary>
public class Domestic: TextEntity{}

/// <summary>
/// GeneralAssessment is a submodel under Telecoommunications model
/// </summary>
public class GeneralAssessment: TextEntity{}

/// <summary>
/// International is a submodel under Telecoommunications model
/// </summary>
public class International: TextEntity{}