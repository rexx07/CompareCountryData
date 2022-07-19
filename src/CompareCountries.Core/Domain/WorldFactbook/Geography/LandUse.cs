using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Geography;

/// <summary>
/// LandUse is a submodel of Geography model.
/// </summary>
public class LandUse
{
    [BsonElement("Agricultural Land")]
    public AgriculturalLand? AgriculturalLand { get; set; }
    [BsonElement("Agricultural land : arable land")]
    public AgriculturalLandArableLand? AgriculturalLandArableLand { get; set; }
    [BsonElement("Agricultural land : permanent crops")]
    public AgriculturalLandPermanentCrops? AgriculturalLandPermanentCrops { get; set; }
    [BsonElement("Agricultural land : permanent pasture")]
    public AgriculturalLandPermanentPasture? AgriculturalLandPermanentPasture { get; set; }
    [BsonElement("Forest Land")]
    public Forest? Forest { get; set; }
    [BsonElement("Other land uses")]
    public Other? Other { get; set; }
}

// <summary>
/// AgriculturalLand is a submodel of LandUse model.
/// </summary>
public class AgriculturalLand: TextEntity{}

/// <summary>
/// AgriculturalLandArableLand is a submodel of LandUse model.
/// </summary>
public class AgriculturalLandArableLand: TextEntity{}

/// <summary>
/// AgriculturalLandPermanentCrops is a submodel of LandUse model.
/// </summary>
public class AgriculturalLandPermanentCrops: TextEntity{}

/// <summary>
/// AgriculturalLandPermanentPasture is a submodel of LandUse model.
/// </summary>
public class AgriculturalLandPermanentPasture: TextEntity{}

/// <summary>
/// forest is a submodel of LandUse model.
/// </summary>
public class Forest: TextEntity{}

/// <summary>
/// Other is a submodel of LandUse model.
/// </summary>
public class Other: TextEntity{}