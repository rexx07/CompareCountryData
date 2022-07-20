using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     InflationRate is a submodel os Economy model.
/// </summary>
[DisplayName("Inflation rate (consumer prices)")]
public class InflationRate
{
    [BsonElement("Inflation rate (consumer prices) 2016")]
    public InflationRate2016? InflationRate2016 { get; set; }

    [BsonElement("Inflation rate (consumer prices) 2017")]
    public InflationRate2017? InflationRate2017 { get; set; }

    [BsonElement("Inflation rate (consumer prices) 2018")]
    public InflationRate2018? InflationRate2018 { get; set; }

    [BsonElement("Inflation rate (consumer prices) 2019")]
    public InflationRate2019? InflationRate2019 { get; set; }
}

/// <summary>
///     InflationRate2016 is a submodel of InflationRate model.
/// </summary>
public class InflationRate2016 : TextEntity
{
}

/// <summary>
///     InflationRate2017 is a submodel of InflationRate model.
/// </summary>
public class InflationRate2017 : TextEntity
{
}

/// <summary>
///     InflationRate2018 is a submodel of InflationRate model.
/// </summary>
public class InflationRate2018 : TextEntity
{
}

/// <summary>
///     InflationRate2019 is a submodel of InflationRate model.
/// </summary>
public class InflationRate2019 : TextEntity
{
}