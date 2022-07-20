using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     NationalAnthem is a submodel of Government model.
/// </summary>
public class NationalAnthem : ExtraNote
{
    [BsonElement("Lyrics/music")] public LyricsMusic? LyricsMusic { get; set; }

    [BsonElement("name")] public Author? Author { get; set; }
}

/// <summary>
///     LyricsMusic is a submodel of NationalAnthem model.
/// </summary>
public class LyricsMusic : TextEntity
{
}

/// <summary>
///     Author is a submodel of NationalAnthem model.
/// </summary>
public class Author : TextEntity
{
}