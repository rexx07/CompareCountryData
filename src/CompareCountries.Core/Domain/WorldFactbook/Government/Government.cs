using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

public class Government: BaseEntity
{
    [BsonElement("Administrative divisions")]
    public AdministrativeDivisions? AdministrativeDivisions { get; set; }
    [BsonElement("Capital")]
    public Capital? Capital { get; set; }
    [BsonElement("Citizenship")]
    public Citizenship? Citizenship { get; set; }
    [BsonElement("Constitution")]
    public Constitution? Constitution { get; set; }
    [BsonElement("Country name")]
    public CountryName? CountryName { get; set; }
    [BsonElement("Diplomatic representation from the us")]
    public DiplomaticRepresentationFromUs? DiplomaticRepresentationFromUs { get; set; }
    [BsonElement("Diplomatic representation in the us")]
    public DiplomaticRepresentationInUs? DiplomaticRepresentationInUs { get; set; }
    [BsonElement("Executive branch")]
    public ExecutiveBranch? ExecutiveBranch { get; set; }
    [BsonElement("Flag description")]
    public FlagDescription? FlagDescription { get; set; }
    [BsonElement("Government type")]
    public GovernmentType? GovernmentType { get; set; }
    [BsonElement("Independence")]
    public Independence? Independence { get; set; }
    [BsonElement("International law organization participation")]
    public IntlLawOrgParticipation? IntlLawOrgParticipation { get; set; }
    [BsonElement("International organization participation")]
    public IntlOrgParticipation? IntlOrgParticipation { get; set; }
    [BsonElement("Judicial branch")]
    public JudicialBranch? JudicialBranch { get; set; }
    [BsonElement("Legal system")]
    public LegalSystem? LegalSystem { get; set; }
    [BsonElement("Legislative Branch")]
    public LegislativeBranch? LegislativeBranch { get; set; }
    [BsonElement("National anthem")]
    public NationalAnthem? NationalAnthem { get; set; }
    [BsonElement("National Heritage")]
    public NationalHeritage? NationalHeritage { get; set; }
    [BsonElement("National Holiday")]
    public NationalHoliday? NationalHoliday { get; set; }
    [BsonElement("National symbol(s)")]
    public NationalSymbols? NationalSymbols { get; set; }
    [BsonElement("Political parties and leaders")]
    public PoliticalPartiesAndLeaders? PoliticalPartiesAndLeaders { get; set; }
    [BsonElement("Suffrage")]
    public Suffrage? Suffrage { get; set; }
}