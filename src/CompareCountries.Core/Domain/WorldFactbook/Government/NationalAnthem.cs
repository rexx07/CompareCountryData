using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// NationalAnthem is a submodel of Government model.
/// </summary>
public class NationalAnthem: MetaData
{
    [BsonElement("Lyrics/music")]
    public LyricsMusic? LyricsMusic { get; set; }
    [BsonElement("name")]
    public Author? Author { get; set; }
}

/// <summary>
/// LyricsMusic is a submodel of NationalAnthem model.
/// </summary>
public class LyricsMusic: TextEntity{}

/// <summary>
/// Author is a submodel of NationalAnthem model.
/// </summary>
public class Author: TextEntity{}