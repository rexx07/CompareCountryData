using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     RealGdpPC is a submodel of Economy model.
/// </summary>
[DisplayName("Real GDP per capita")]
public class RealGdpPC : ExtraNote
{
    [BsonElement("Real GDP per capita 2018")]
    public RealGdpPC2018? RealGdpPC2018 { get; set; }

    [BsonElement("Real GDP per capita 2019")]
    public RealGdpPC2019? RealGdpPC2019 { get; set; }

    [BsonElement("Real GDP per capita 2018")]
    public RealGdpPC2020? RealGdpPC2020 { get; set; }
}

/// <summary>
///     RealGdpPC2018 is a submodel of RealGdpPc model.
/// </summary>
public class RealGdpPC2018 : TextEntity
{
}

/// <summary>
///     RealGdpPC2019 is a submodel of RealGdpPc model.
/// </summary>
public class RealGdpPC2019 : TextEntity
{
}

/// <summary>
///     RealGdpPC2020 is a submodel of RealGdpPc model.
/// </summary>
public class RealGdpPC2020 : TextEntity
{
}