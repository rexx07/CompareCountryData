using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environments;

/// <summary>
///     TotalWaterWithdrawal is a submodel of Environment model.
/// </summary>
public class TotalWaterWithdrawal
{
    [BsonElement("Agricultural")] public Agricultural? Agricultural { get; set; }

    [BsonElement("Industrial")] public Industrial? Industrial { get; set; }

    [BsonElement("Municipal")] public Municipal? Municipal { get; set; }
}

/// <summary>
///     Agricultural is a submodel of TotalWaterWithdrawal model.
/// </summary>
public class Agricultural : TextEntity
{
}

/// <summary>
///     Industrial is a submodel of TotalWaterWithdrawal model.
/// </summary>
public class Industrial : TextEntity
{
}

/// <summary>
///     Municipal is a submodel of TotalWaterWithdrawal model.
/// </summary>
public class Municipal : TextEntity
{
}