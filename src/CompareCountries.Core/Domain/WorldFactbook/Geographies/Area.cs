using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Geographies;

/// <summary>
///     Area is a submodel of Geography model
/// </summary>
public class Area
{
    [BsonElement("Land")] public AreaLand? Land { get; set; }

    [BsonElement("Water")] public AreaWater? Water { get; set; }

    [BsonElement("Total")] public AreaTotal? AreaTotal { get; set; }
}

/// <summary>
///     Land is a submodel of Area model
/// </summary>
public class AreaLand : TextEntity
{
}

/// <summary>
///     Water is a submodel of Area model
/// </summary>
public class AreaWater : TextEntity
{
}

/// <summary>
///     Total is a submodel of Area model
/// </summary>
public class AreaTotal : TextEntity
{
}