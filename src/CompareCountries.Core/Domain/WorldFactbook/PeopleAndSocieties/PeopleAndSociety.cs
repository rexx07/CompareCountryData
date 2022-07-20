using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

public class PeopleAndSociety : BaseEntity
{
    [BsonElement("Age structure")] public AgeStructure? AgeStructure { get; set; }

    [BsonElement("Birth rate")] public BirthRate? BirthRate { get; set; }

    [BsonElement("Child marriage")] public ChildMarriage? ChildMarriage { get; set; }

    [BsonElement("Children under the age of 5 years underweight")]
    public ChildrenUnder5Underweight? ChildrenUnder5Underweight { get; set; }

    [BsonElement("Contraceptive prevalence rate")]
    public ContraceptivePrevalenceRate? ContraceptivePrevalenceRate { get; set; }

    [BsonElement("Current Health Expenditure")]
    public CurrentHealthExpenditure? CurrentHealthExpenditure { get; set; }

    [BsonElement("Death rate")] public DeathRate? DeathRate { get; set; }

    [BsonElement("Demographic profile")] public DemographicProfile? DemographicProfile { get; set; }

    [BsonElement("Dependency ratio")] public DependencyRatio? DependencyRatio { get; set; }

    [BsonElement("Drinking water source")] public DrinkingWaterSource? DrinkingWaterSource { get; set; }

    [BsonElement("Education expenditures")]
    public EducationExpenditures? EducationExpenditures { get; set; }

    [BsonElement("Ethnic groups")] public EthnicGroups? EthnicGroups { get; set; }

    [BsonElement("Hiv/Aids - adult prevalence rate")]
    public HivAidsAdults? HivAidsAdults { get; set; }

    [BsonElement("Hiv/Aids - deaths")] public HivAidsDeath? HivAidsDeath { get; set; }

    [BsonElement("Hiv/Aids - people living with Hiv/Aids")]
    public HivAidsPeople? HivAidsPeople { get; set; }

    [BsonElement("Hospital bed density")] public HospitalBedDensity? HospitalBedDensity { get; set; }

    [BsonElement("Infant mortality rate")] public InfantMortalityRate? InfantMortalityRate { get; set; }

    [BsonElement("Languages")] public Languages? Languages { get; set; }

    [BsonElement("Life expectancy at birth")]
    public LifeExpectancyAtBirth? LifeExpectancyAtBirth { get; set; }

    [BsonElement("Literacy")] public Literacy? Literacy { get; set; }

    [BsonElement("Major infectious diseases")]
    public MajorInfectiousDiseases? MajorInfectiousDiseases { get; set; }

    [BsonElement("Major urn=ban ares - population")]
    public MajorUrbanAreasPopulation? MajorUrbanAreasPopulation { get; set; }

    [BsonElement("Maternal mortality ratio")]
    public MaternalMortalityRatio? MaternalMortalityRatio { get; set; }

    [BsonElement("Media age")] public MedianAge? MedianAge { get; set; }

    [BsonElement("Mother's mean age at first birth")]
    public MothersMeanAgeAtFirstBirth? MothersMeanAgeAtFirstBirth { get; set; }

    [BsonElement("Nationality")] public Nationality? Nationality { get; set; }

    [BsonElement("Net migration rate")] public NetMigrationRate? NetMigrationRate { get; set; }

    [BsonElement("Obesity - adult prevalence rate")]
    public Obesity? Obesity { get; set; }

    [BsonElement("Physicians density")] public PhysiciansDensity? PhysiciansDensity { get; set; }

    [BsonElement("Population")] public Population? Population { get; set; }

    [BsonElement("Population distribution")]
    public PopulationDistribution? PopulationDistribution { get; set; }

    [BsonElement("Population growth rate")]
    public PopulationGrowthRate? PopulationGrowthRate { get; set; }

    [BsonElement("Religions")] public Religions? Religions { get; set; }

    [BsonElement("Sanitation facility access")]
    public SanitationFacilityAccess? SanitationFacilityAccess { get; set; }

    [BsonElement("School life expectancy (primary to tertiary education)")]
    public SchoolLifeExpectancy? SchoolLifeExpectancy { get; set; }

    [BsonElement("Sex ratio")] public SexRatio? SexRatio { get; set; }

    [BsonElement("Tobacco use")] public TobaccoUse? TobaccoUse { get; set; }

    [BsonElement("Total fertility rate")] public TotalFertilityRate? TotalFertilityRate { get; set; }

    [BsonElement("Unemployment, youth ages 15-24")]
    public UnemployedYouths? UnemployedYouths { get; set; }

    [BsonElement("Urbanization")] public Urbanization? Urbanization { get; set; }
}