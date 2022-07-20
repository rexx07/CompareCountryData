using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     AgeStructure is a submodel of PeopleAndSociety model.
/// </summary>
public class AgeStructure
{
    [BsonElement("0-14 years")] public ChildrenAge? ChildrenAge { get; set; }

    [BsonElement("15-24 years")] public YoungAdultAge? YoungAdultAge { get; set; }

    [BsonElement("25-54 years")] public AdultAge? AdultAge { get; set; }

    [BsonElement("55-64 years")] public OlderAdultAge? OlderAdultAge { get; set; }

    [BsonElement("65 years and over")] public OldAge? OldAge { get; set; }
}

/// <summary>
///     ChildrenAge is a submodel of AgeStructure model.
/// </summary>
public class ChildrenAge : TextEntity
{
}

/// <summary>
///     YoungAdultAge is a submodel of AgeStructure model.
/// </summary>
public class YoungAdultAge : TextEntity
{
}

/// <summary>
///     AdultAge is a submodel of AgeStructure model.
/// </summary>
public class AdultAge : TextEntity
{
}

/// <summary>
///     OlderAdultAge is a submodel of AgeStructure model.
/// </summary>
public class OlderAdultAge : TextEntity
{
}

/// <summary>
///     OldAge is a submodel of AgeStructure model.
/// </summary>
public class OldAge : TextEntity
{
}