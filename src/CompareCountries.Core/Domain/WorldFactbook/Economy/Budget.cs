using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// Budget is a submodel under economy model
/// </summary>
public class Budget
{
    [BsonElement("Expenditures")]
    public Expenditures? Expenditures { get; set; }
    [BsonElement("Revenues")]
    public Revenues? Revenues { get; set; }
}

/// <summary>
/// Expenditure is a submodel under Budget model
/// </summary>
public class Expenditures: TextEntity{}

/// <summary>
/// Revenues is a submodel under Budget model.
/// </summary>
public class Revenues: TextEntity{}