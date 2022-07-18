namespace CompareCountries.Core.Domain.WorldFactbook;

public class TransNationalIssues: BaseEntity
{
    public string? DisputesInternational { get; set; }
    public string? RefugeesAndInternallyDisplacedPersons { get; set; }
    public string? TraffickingInPersons { get; set; }
    public string? IllicitDrugs { get; set; }
}