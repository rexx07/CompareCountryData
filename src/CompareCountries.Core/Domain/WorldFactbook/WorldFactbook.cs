using MongoDB.Bson;

namespace CompareCountries.Core.Domain.WorldFactbook;

public class WorldFactbook: BaseEntity
{
    public BsonDocument? CommunicationsList { get; set; }
    public BsonDocument? Economies { get; set; }
    public BsonDocument? Energies { get; set; }
    public BsonDocument? Environments { get; set; }
    public BsonDocument? Geographies { get; set; }
    public BsonDocument? Governments { get; set; }
    public BsonDocument? Introductions { get; set; }
    public BsonDocument? MilitaryAndSecurities { get; set; }
    public BsonDocument? PeopleAndSocieties { get; set; }
    public BsonDocument? Terrorisms { get; set; }
    public BsonDocument? TransNationalIssuesList { get; set; }
    public BsonDocument? Transportations { get; set; }
}