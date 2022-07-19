using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Environment;

/// <summary>
///     FoodInsecurity is a submodel of Environment model.
/// </summary>
public class FoodInsecurity
{
    [BsonElement("Severe localized food insecurity")]
    public SevereLocalizedFoodInsecurity? SevereLocalizedFoodInsecurity { get; set; }

    [BsonElement("Widespread lack of access")]
    public WidespreadLackOfAccess? WidespreadLackOfAccess { get; set; }
}

/// <summary>
///     SevereLocalizedFoodInsecurity is a submodel of Environment model.
/// </summary>
public class SevereLocalizedFoodInsecurity : TextEntity
{
}

/// <summary>
///     WidespreadLackOfAccess is a submodel of Environment model.
/// </summary>
public class WidespreadLackOfAccess : TextEntity
{
}