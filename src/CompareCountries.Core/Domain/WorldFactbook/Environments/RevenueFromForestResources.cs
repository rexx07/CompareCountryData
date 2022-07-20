using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environments;

/// <summary>
///     RevenueFromForestResources is a submodel of Environment model.
/// </summary>
public class RevenueFromForestResources
{
    [BsonElement("Forest Revenues")] public ForestRevenues? ForestRevenues { get; set; }
}

/// <summary>
///     ForestRevenues is a submodel of RevenueFromForestResources model.
/// </summary>
public class ForestRevenues : TextEntity
{
}