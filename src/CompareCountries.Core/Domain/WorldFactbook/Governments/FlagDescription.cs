using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     FlagDescription is submodel of Government model.
/// </summary>
public class FlagDescription : ExtraNote
{
    [BsonElement("Text")] public FlagText? FlagText { get; set; }
}

/// <summary>
///     FlagText is a submodel of FlagDescription model.
/// </summary>
public class FlagText : TextEntity
{
}