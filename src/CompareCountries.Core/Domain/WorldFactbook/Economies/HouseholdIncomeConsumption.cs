using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     HouseholdIncomeConsumption is a submodel of model.
/// </summary>
[DisplayName("Household income or consumption by percentage share")]
public class HouseholdIncomeConsumption
{
    [BsonElement("Highest 10%")] public Highest? Highest { get; set; }

    [BsonElement("Lowest 10%")] public Lowest Lowest { get; set; }
}

/// <summary>
///     Highest is  submodel of HouseholdIncomeConsumption model.
/// </summary>
public class Highest : TextEntity
{
}

/// <summary>
///     Lowest is  submodel of HouseholdIncomeConsumption model.
/// </summary>
public class Lowest : TextEntity
{
}