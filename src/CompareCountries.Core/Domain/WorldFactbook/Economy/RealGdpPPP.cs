using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// RealGdpPPP is a submodel of Economy model.
/// </summary>
[DisplayName("Real GDP (purchasing power parity)")]
public class RealGdpPPP: MetaData
{
    [BsonElement("Real GDP (purchasing power parity) 2018")]
    public RealGdpPPP2018 RealGdpPpp2018 { get; set; }
    [BsonElement("Real GDP (purchasing power parity) 2019")]
    public RealGdpPPP2019 RealGdpPpp2019 { get; set; }
    [BsonElement("Real GDP (purchasing power parity) 2020")]
    public RealGdpPPP2020 RealGdpPpp2020 { get; set; }
}

/// <summary>
/// RealGdpPPP2018 is a submodel of RealGdpPPP model.
/// </summary>
public class RealGdpPPP2018: TextEntity{}

/// <summary>
/// RealGdpPPP2019 is a submodel of RealGdpPPP model.
/// </summary>
public class RealGdpPPP2019: TextEntity{}

/// <summary>
/// RealGdpPPP2020 is a submodel of RealGdpPPP model.
/// </summary>
public class RealGdpPPP2020: TextEntity{}