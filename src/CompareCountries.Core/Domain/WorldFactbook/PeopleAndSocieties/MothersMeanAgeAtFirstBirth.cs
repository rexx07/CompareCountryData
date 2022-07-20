using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     MothersMeanAgeAtFirstBirth is a submodel of PeopleAndSociety model.
/// </summary>
public class MothersMeanAgeAtFirstBirth : ExtraNote
{
    [BsonElement("text")] public MothersMeanAgeAtFirstBirthText? MothersMeanAgeAtFirstBirthText { get; set; }
}

/// <summary>
///     MothersMeanAgeAtFirstBirthText is a submodel of MothersMeanAgeAtFirstBirth model.
/// </summary>
public class MothersMeanAgeAtFirstBirthText : TextEntity
{
}