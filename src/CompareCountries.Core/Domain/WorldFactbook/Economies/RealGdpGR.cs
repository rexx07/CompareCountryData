using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     RealGdpGr is a submodel of Economy model.
/// </summary>
[DisplayName("Real GDP growth rate")]
public class RealGdpGR
{
    [BsonElement("Real GDP growth rate 2015")]
    public RealGdpGR2015? RealGdpGr2015 { get; set; }

    [BsonElement("Real GDP growth rate 2016")]
    public RealGdpGR2016? RealGdpGr2016 { get; set; }

    [BsonElement("Real GDP growth rate 2017")]
    public RealGdpGR2017? RealGdpGr2017 { get; set; }
}

/// <summary>
///     RealGdpGR2015 is a submodel of economy model.
/// </summary>
public class RealGdpGR2015 : TextEntity
{
}

/// <summary>
///     RealGdpGR2016 is a submodel of economy model.
/// </summary>
public class RealGdpGR2016 : TextEntity
{
}

/// <summary>
///     RealGdpGR2017 is a submodel of economy model.
/// </summary>
public class RealGdpGR2017 : TextEntity
{
}