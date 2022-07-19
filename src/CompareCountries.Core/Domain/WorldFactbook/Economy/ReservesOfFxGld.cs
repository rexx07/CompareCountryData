using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// ReservesOfFxGld is a submodel of Economy model.
/// </summary>
[DisplayName("Reserves of foreign exchange and gold")]
public class ReservesOfFxGld
{
    [BsonElement("Reserves of foreign exchange and gold 2016")]
    public ReserveOfFxGld2016? ReserveOfFxGld2016 { get; set; }
    [BsonElement("Reserves of foreign exchange and gold 2017")]
    public ReserveOfFxGld2017? ReserveOfFxGld2017 { get; set; }
}

/// <summary>
/// ReservesOfFxGld2016 is a submodel of ReservesOfFxGld model.
/// </summary>
public class ReserveOfFxGld2016: TextEntity{}

/// <summary>
/// ReservesOfFxGld2017 is a submodel of ReservesOfFxGld model.
/// </summary>
public class ReserveOfFxGld2017: TextEntity{}