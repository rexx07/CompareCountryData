using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Geography;

/// <summary>
/// LandBoundaries is a submodel of Geography model. 
/// </summary>
public class LandBoundaries
{
    [BsonElement("Border countries")]
    public BorderCountries? BorderCountries { get; set; }
    [BsonElement("Total")]
    public BoundariesTotal? BoundariesTotal { get; set; }
}

/// <summary>
/// BorderCountries is a submodel of Geography model.
/// </summary>
public class BorderCountries: TextEntity{}

/// <summary>
/// Total is a submodel of Geography model.
/// </summary>
public class BoundariesTotal: TextEntity{}