using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Transportations;

/// <summary>
///     Roadways is a submodel of Transportation model.
/// </summary>
public class Roadways : ExtraNote
{
    [BsonElement("Non-urban")] public NonUrban? NonUrban { get; set; }

    [BsonElement("Paved")] public Paved? Paved { get; set; }

    [BsonElement("total")] public RoadwaysTotal? RoadwaysTotal { get; set; }

    [BsonElement("Unpaved")] public Unpaved? Unpaved { get; set; }

    [BsonElement("Urban")] public Urban? Urban { get; set; }
}

/// <summary>
///     NonUrban is a submodel of Roadways model.
/// </summary>
public class NonUrban : TextEntity
{
}

/// <summary>
///     Paved is a submodel of Roadways model.
/// </summary>
public class Paved : TextEntity
{
}

/// <summary>
///     RoadwaysTotal is a submodel of Roadways model.
/// </summary>
public class RoadwaysTotal : TextEntity
{
}

/// <summary>
///     Unpaved is a submodel of Roadways model.
/// </summary>
public class Unpaved : TextEntity
{
}

/// <summary>
///     Urban is a submodel of Roadways model.
/// </summary>
public class Urban : TextEntity
{
}