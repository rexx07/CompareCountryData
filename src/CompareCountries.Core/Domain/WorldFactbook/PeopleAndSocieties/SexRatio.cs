using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     SexRatio is a submodel of PeopleAndSociety model.
/// </summary>
public class SexRatio
{
    [BsonElement("0-14 years")] public ChildrenSexRatio? ChildrenSexRatio { get; set; }

    [BsonElement("15-24 years")] public YoungAdultSexRatio? YoungAdultSexRatio { get; set; }

    [BsonElement("25-54 years")] public AdultSexRatio? AdultSexRatio { get; set; }

    [BsonElement("55-64 years")] public OlderAdultSexRatio? OlderAdultSexRatio { get; set; }

    [BsonElement("65 years and over")] public OldSexRatio? OldAge { get; set; }

    [BsonElement("At birth")] public AtBirthSexRatio? AtBirthSexRatio { get; set; }

    [BsonElement("total population")] public TotalPopulationAtBirth? TotalPopulationAtBirth { get; set; }
}

/// <summary>
///     ChildrenSexRatio is a submodel of SexRatio model.
/// </summary>
public class ChildrenSexRatio : TextEntity
{
}

/// <summary>
///     YoungAdultSexRatio is a submodel of SexRatio model.
/// </summary>
public class YoungAdultSexRatio : TextEntity
{
}

/// <summary>
///     AdultSexRatio is a submodel of SexRatio model.
/// </summary>
public class AdultSexRatio : TextEntity
{
}

/// <summary>
///     OlderAdultSexRatio is a submodel of SexRatio model.
/// </summary>
public class OlderAdultSexRatio : TextEntity
{
}

/// <summary>
///     OldSexRatio is a submodel of SexRatio model.
/// </summary>
public class OldSexRatio : TextEntity
{
}

/// <summary>
///     AtBirthSexRatio is a submodel of SexRatio model.
/// </summary>
public class AtBirthSexRatio : TextEntity
{
}

/// <summary>
///     TotalPopulationAtBirth is a submodel of SexRatio model.
/// </summary>
public class TotalPopulationAtBirth : TextEntity
{
}