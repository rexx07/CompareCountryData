using MongoDB.Bson;

namespace CompareCountries.Core.Domain.WorldFactbook;

public class Government: BaseEntity
{
    public BsonDocument? CountryName { get; set; }
    public BsonDocument? GovernmentType { get; set; }
    public BsonDocument? Capital { get; set; }
    public BsonDocument? AdministrativeDivision { get; set; }
    public BsonDocument? Independence { get; set; }
    public BsonDocument? NationalHolidays { get; set; }
    public BsonDocument? Constitution { get; set; }
    public BsonDocument? LegalSystem { get; set; }
    public BsonDocument? InternationalLawOrganizationParticipation { get; set; }
    public BsonDocument? Citizenship { get; set; }
    public BsonDocument? Suffrage { get; set; }
    public BsonDocument? ExecutiveBranch { get; set; }
    public BsonDocument? LegislativeBranch { get; set; }
    public BsonDocument? JudicialBranch { get; set; }
    public BsonDocument? PoliticalPartiesAndLeaders { get; set; }
    public BsonDocument? InternationalOrganizationParticipation { get; set; }
    public BsonDocument? DiplomaticRepresentationInTheUs { get; set; }
    public BsonDocument? DiplomaticRepresentationFromTheUs { get; set; }
    public BsonDocument? FlagDescription { get; set; }
    public BsonDocument? NationalSymbols { get; set; }
    public BsonDocument? NationalAnthem { get; set; }
    public BsonDocument? NationalHeritage { get; set; }
}