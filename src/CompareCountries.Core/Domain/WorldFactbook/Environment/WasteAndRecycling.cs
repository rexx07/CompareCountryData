using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environment;

/// <summary>
///     WasteAndRecycling is a submodel of Environment model.
/// </summary>
public class WasteAndRecycling
{
    [BsonElement("Municipal solid waste generated annually")]
    public MunicipalSolidWasteGeneratedAnnually? MunicipalSolidWasteGeneratedAnnually { get; set; }

    [BsonElement("Municipal solid waste recycled annually")]
    public MunicipalSolidWasteRecycledAnnually? MunicipalSolidWasteRecycledAnnually { get; set; }

    [BsonElement("Percent Of Municipal Solid Waste Recycled")]
    public PercentOfMunicipalSolidWasteRecycled? PercentOfMunicipalSolidWasteRecycled { get; set; }
}

/// <summary>
///     MunicipalSolidWasteGeneratedAnnually is a submodel of WasteAndRecycling model.
/// </summary>
public class MunicipalSolidWasteGeneratedAnnually : TextEntity
{
}

/// <summary>
///     MunicipalSolidWasteRecycledAnnually is a submodel of WasteAndRecycling model.
/// </summary>
public class MunicipalSolidWasteRecycledAnnually : TextEntity
{
}

/// <summary>
///     PercentOfMunicipalSolidWasteRecycled is a submodel of WasteAndRecycling model.
/// </summary>
public class PercentOfMunicipalSolidWasteRecycled : TextEntity
{
}