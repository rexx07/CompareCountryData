using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// UnemployedYouth is a submodel of Economy model.
/// </summary>
[DisplayName("Unemployed youth of ages 15-24")]
public class UnemployedYouth
{
    [BsonElement("Unemployed female of ages 15-24")]
    public UnemployedFemale? UnemployedFemale { get; set; }
    [BsonElement("Unemployed male of ages 15-24")]
    public UnemployedMale? UnemployedMale { get; set; }
    [BsonElement("Unemployed youth total of ages 15-24")]
    public UnemployedYouthTotal? UnemployedYouthTotal { get; set; }
}

/// <summary>
/// UnemployedFemale is a submodel of UnemployedYouth model.
/// </summary>
public class UnemployedFemale: TextEntity{}

/// <summary>
/// UnemployedMale is a submodel of UnemployedYouth model.
/// </summary>
public class UnemployedMale: TextEntity{}

/// <summary>
/// UnemployedYouthTotal is a submodel of UnemployedYouth model.
/// </summary>
public class UnemployedYouthTotal: TextEntity{}