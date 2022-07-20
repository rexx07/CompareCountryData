using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Communications;

/// <summary>
///     a submodel of communications model
/// </summary>
public class InternetUsers
{
    [BsonElement("Percent Of Population")] public PercentOfPopulation PercentOfPopulation { get; set; }

    [BsonElement("Total number of internet users")]
    public InternetUserTotal InternetUserTotal { get; set; }
}

/// <summary>
///     a submodel of InternetUsers model
/// </summary>
public class PercentOfPopulation : TextEntity
{
}

/// <summary>
///     a submodel of InternetUsers model
/// </summary>
public class InternetUserTotal : TextEntity
{
}