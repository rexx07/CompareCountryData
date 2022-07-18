using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// GdpCompositionBySector is a submodel of economy model.
/// </summary>
[DisplayName("GDP - composition, by sector of origin")]
public class GdpCompositionBySector
{
    [BsonElement("Agriculture")]
    public Agriculture Agriculture { get; set; }
    [BsonElement("Industry")]
    public Agriculture Industry { get; set; }
    [BsonElement("Services")]
    public Agriculture Services { get; set; }
}

/// <summary>
/// Agriculture is a submodel of GdpCompositionBySector
/// </summary>
public class Agriculture: TextEntity{}

/// <summary>
/// Industry is a submodel of GdpCompositionBySector
/// </summary>
public class Industry: TextEntity{}

/// <summary>
/// Services is a submodel of GdpCompositionBySector
/// </summary>
public class Services: TextEntity{}