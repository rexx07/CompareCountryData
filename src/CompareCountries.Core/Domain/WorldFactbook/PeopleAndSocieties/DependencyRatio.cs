using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     DependencyRatio is a submodel of PeopleAndSociety model.
/// </summary>
public class DependencyRatio
{
    [BsonElement("Elderly dependency ratio")]
    public ElderlyDependencyRatio? ElderlyDependencyRatio { get; set; }

    [BsonElement("Potential support ratio")]
    public PotentialSupportRatio? PotentialSupportRatio { get; set; }

    [BsonElement("Total dependency ratio")]
    public TotalDependencyRatio? TotalDependencyRatio { get; set; }

    [BsonElement("Youth dependency ratio")]
    public YouthDependencyRatio? YouthDependencyRatio { get; set; }
}

/// <summary>
///     ElderlyDependencyRatio is a submodel of DependencyRatio model.
/// </summary>
public class ElderlyDependencyRatio : TextEntity
{
}

/// <summary>
///     PotentialSupportRatio is a submodel of DependencyRatio model.
/// </summary>
public class PotentialSupportRatio : TextEntity
{
}

/// <summary>
///     TotalDependencyRatio is a submodel of DependencyRatio model.
/// </summary>
public class TotalDependencyRatio : TextEntity
{
}

/// <summary>
///     YouthDependencyRatio is a submodel of DependencyRatio model.
/// </summary>
public class YouthDependencyRatio : TextEntity
{
}