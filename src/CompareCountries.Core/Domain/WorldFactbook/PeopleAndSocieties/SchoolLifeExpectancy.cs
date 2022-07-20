using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     SchoolLifeExpectancy is a submodel of PeopleAndSociety model.
/// </summary>
public class SchoolLifeExpectancy
{
    [BsonElement("female")] public FemaleSchoolLifeExpectancy? FemaleSchoolLifeExpectancy { get; set; }

    [BsonElement("Male")] public MaleSchoolLifeExpectancy? MaleSchoolLifeExpectancy { get; set; }

    [BsonElement("total")] public SchoolLifeExpectancyTotal? SchoolLifeExpectancyTotal { get; set; }
}

/// <summary>
///     FemaleSchoolLifeExpectancy is a submodel of SchoolLifeExpectancy model.
/// </summary>
public class FemaleSchoolLifeExpectancy : TextEntity
{
}

/// <summary>
///     MaleSchoolLifeExpectancy is a submodel of SchoolLifeExpectancy model.
/// </summary>
public class MaleSchoolLifeExpectancy : TextEntity
{
}

/// <summary>
///     SchoolLifeExpectancyTotal is a submodel of SchoolLifeExpectancy model.
/// </summary>
public class SchoolLifeExpectancyTotal : TextEntity
{
}