using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     TobaccoUse is a submodel of PeopleAndSociety model.
/// </summary>
public class TobaccoUse
{
    [BsonElement("female")] public FemaleTobaccoUse? FemaleTobaccoUse { get; set; }

    [BsonElement("Male")] public MaleTobaccoUse? MaleTobaccoUse { get; set; }

    [BsonElement("total")] public TotalTobaccoUse? TotalTobaccoUse { get; set; }
}

/// <summary>
///     FemaleTobaccoUse is a submodel of TobaccoUse model.
/// </summary>
public class FemaleTobaccoUse : TextEntity
{
}

/// <summary>
///     MaleTobaccoUse is a submodel of TobaccoUse model.
/// </summary>
public class MaleTobaccoUse : TextEntity
{
}

/// <summary>
///     TotalTobaccoUse is a submodel of TobaccoUse model.
/// </summary>
public class TotalTobaccoUse : TextEntity
{
}