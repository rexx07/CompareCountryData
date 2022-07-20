using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Terrorisms;

/// <summary>
///     TerroristGroups is a sublabel of terrorist model.
/// </summary>
public class TerroristGroups : ExtraNote
{
    [BsonElement("text")] public TerroristGroupText? TerroristGroupText { get; set; }
}

/// <summary>
///     TerroristGroupText is a submodel of TerroristGroups model.
/// </summary>
public class TerroristGroupText : TextEntity
{
}