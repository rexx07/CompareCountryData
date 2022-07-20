namespace CompareCountries.Core.Domain.WorldFactbook.TransnationalIssues;

public class TransNationalIssue : BaseEntity
{
    public string? DisputesInternational { get; set; }
    public string? RefugeesAndInternallyDisplacedPersons { get; set; }
    public string? TraffickingInPersons { get; set; }
    public string? IllicitDrugs { get; set; }
}