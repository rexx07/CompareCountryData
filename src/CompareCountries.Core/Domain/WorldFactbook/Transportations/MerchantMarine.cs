using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     MerchantMarine is a submodel of Transporatation model.
/// </summary>
public class MerchantMarine : TextEntity
{
    [BsonElement("By type")] public ByType? ByType { get; set; }

    [BsonElement("Total")] public MerchantMarineTotal? MerchantMarineTotal { get; set; }
}

/// <summary>
///     ByType is a subtype of MerchantMarine model.
/// </summary>
public class ByType : TextEntity
{
}

/// <summary>
///     MerchantMarineTotal is a subtype of MerchantMarine model.
/// </summary>
public class MerchantMarineTotal : TextEntity
{
}