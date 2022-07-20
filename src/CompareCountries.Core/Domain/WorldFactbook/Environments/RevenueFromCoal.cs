using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environments;

/// <summary>
///     RevenueFromCoal is submodel of Environment model
/// </summary>
public class RevenueFromCoal
{
    [BsonElement("Revenue from coal")] public CoalRevenues? CoalRevenues { get; set; }
}

/// <summary>
///     CoalRevenues is a submodel of RevenueFromCoal
/// </summary>
public class CoalRevenues : TextEntity
{
}