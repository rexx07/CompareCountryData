using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     CurrentAccountBalance is a submodel under Economy model.
/// </summary>
public class CurrentAccountBalance
{
    [BsonElement("Current account balance in 2016")]
    public CurrentAccountBalance2016? CurrentAccountBalance2016 { get; set; }

    [BsonElement("Current account balance in 2017")]
    public CurrentAccountBalance2017? CurrentAccountBalance2017 { get; set; }
}

/// <summary>
///     CurrentAccountBalance2016 is a submodel under CurrentAccountBalance.
/// </summary>
public class CurrentAccountBalance2016 : TextEntity
{
}

/// <summary>
///     CurrentAccountBalance2017 is a submodel under CurrentAccountBalance.
/// </summary>
public class CurrentAccountBalance2017 : TextEntity
{
}