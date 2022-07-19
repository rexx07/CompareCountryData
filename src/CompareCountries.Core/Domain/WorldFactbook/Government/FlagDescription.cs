using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// FlagDescription is submodel of Government model.
/// </summary>
public class FlagDescription: MetaData
{
    [BsonElement("note")]
    public FlagNote? FlagNote { get; set; }
}

/// <summary>
/// FlagNote is a submodel of FlagDescription model.
/// </summary>
public class FlagNote: TextEntity{}