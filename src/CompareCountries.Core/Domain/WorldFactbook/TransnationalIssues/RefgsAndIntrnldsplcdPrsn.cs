using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.TransnationalIssues;

/// <summary>
///     RefgsAndIntrnldsplcdPrsn is a submodel of TransnationalIssues model.
/// </summary>
[DisplayName("Refugees and internally displaced persons")]
public class RefgsAndIntrnldsplcdPrsn
{
    [BsonElement("Idps")] public Idps? Idps { get; set; }

    [BsonElement("Refugees (country of origin)")]
    public Refugees? Refugees { get; set; }

    [BsonElement("Stateless persons")] public StatelessPersons? StatelessPersons { get; set; }
}

/// <summary>
///     Idps is a submodel of RefgsAndIntrnldsplcdPrsn model.
/// </summary>
public class Idps : TextEntity
{
}

/// <summary>
///     Refugees is a submodel of RefgsAndIntrnldsplcdPrsn model.
/// </summary>
public class Refugees : TextEntity
{
}

/// <summary>
///     StatelessPersons is a submodel of RefgsAndIntrnldsplcdPrsn model.
/// </summary>
public class StatelessPersons : TextEntity
{
}