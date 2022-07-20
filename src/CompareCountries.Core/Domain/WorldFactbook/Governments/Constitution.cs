using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     Constitution is a submodel of Government model.
/// </summary>
public class Constitution : ExtraNote
{
    [BsonElement("Amendments")] public Amendments? Amendments { get; set; }

    [BsonElement("History")] public History? History { get; set; }
}

/// <summary>
///     Amendments is a submodel of Constitution model.
/// </summary>
public class Amendments : TextEntity
{
}

/// <summary>
///     History is a submodel of Constitution model.
/// </summary>
public class History : TextEntity
{
}