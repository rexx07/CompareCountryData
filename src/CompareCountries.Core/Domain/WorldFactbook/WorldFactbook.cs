using CompareCountries.Core.Domain.WorldFactbook.Communications;
using CompareCountries.Core.Domain.WorldFactbook.Economies;
using CompareCountries.Core.Domain.WorldFactbook.Energies;
using CompareCountries.Core.Domain.WorldFactbook.Geographies;
using CompareCountries.Core.Domain.WorldFactbook.Governments;
using CompareCountries.Core.Domain.WorldFactbook.TransnationalIssues;
using CompareCountries.Core.Domain.WorldFactbook.Introductions;
using CompareCountries.Core.Domain.WorldFactbook.MilitariesAndSecurities;
using CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;
using CompareCountries.Core.Domain.WorldFactbook.Terrorisms;
using CompareCountries.Core.Domain.WorldFactbook.Transportations;
using Environment = CompareCountries.Core.Domain.WorldFactbook.Environments.Environment;

namespace CompareCountries.Core.Domain.WorldFactbook;

public class WorldFactbook : BaseEntity
{
    public Communication? Communication { get; set; }
    public Economy? Economy { get; set; }
    public Energy? Energy { get; set; }
    public Environment? Environment { get; set; }
    public Geography? Geography { get; set; }
    public Government? Government { get; set; }
    public Introduction? Introduction { get; set; }
    public MilitaryAndSecurity? MilitaryAndSecurity { get; set; }
    public PeopleAndSociety? PeopleAndSociety { get; set; }
    public Terrorism? Terrorism { get; set; }
    public TransNationalIssue? TransnationalIssue { get; set; }
    public Transportation? Transportation { get; set; }
}