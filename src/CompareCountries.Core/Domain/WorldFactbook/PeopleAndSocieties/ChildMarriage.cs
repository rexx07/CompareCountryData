using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     ChildMarriage is a submodel of PeopleAndSociety model.
/// </summary>
public class ChildMarriage
{
    [BsonElement("Men married by age 18")] public MenMarriedByAge18? MenMarriedByAge18 { get; set; }

    [BsonElement("Women married by age 15")]
    public WomenMarriedByAge15? WomenMarriedByAge15 { get; set; }

    [BsonElement("Women married by age 18")]
    public WomenMarriedByAge18? WomenMarriedByAge18 { get; set; }
}

/// <summary>
///     MenMarriedByAge18 is a submodel of ChildMarriage model
/// </summary>
public class MenMarriedByAge18 : TextEntity
{
}

/// <summary>
///     WomenMarriedByAge15 is a submodel of ChildMarriage model
/// </summary>
public class WomenMarriedByAge15 : TextEntity
{
}

/// <summary>
///     WomenMarriedByAge18 is a submodel of ChildMarriage model
/// </summary>
public class WomenMarriedByAge18 : TextEntity
{
}