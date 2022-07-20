using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     UnemployedYouths is a submodel of PeopleAndSociety model.
/// </summary>
[DisplayName("Unemployment, youth ages 15-24")]
public class UnemployedYouths
{
    [BsonElement("female")] public FemaleUnemployedYouths? FemaleUnemployedYouths { get; set; }

    [BsonElement("Male")] public MaleUnemployedYouths? MaleUnemployedYouths { get; set; }

    [BsonElement("total")] public TotalUnemployedYouths? TotalUnemployedYouths { get; set; }
}

/// <summary>
///     FemaleTUnemployedYouths is a submodel of UnemployedYouths model.
/// </summary>
public class FemaleUnemployedYouths : TextEntity
{
}

/// <summary>
///     MaleUnemployedYouths is a submodel of UnemployedYouths model.
/// </summary>
public class MaleUnemployedYouths : TextEntity
{
}

/// <summary>
///     TotalUnemployedYouths is a submodel of UnemployedYouths model.
/// </summary>
public class TotalUnemployedYouths : TextEntity
{
}