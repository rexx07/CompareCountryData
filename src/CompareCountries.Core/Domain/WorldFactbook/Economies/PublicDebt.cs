using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     PublicDebt is a submodel of Economy model.
/// </summary>
public class PublicDebt : ExtraNote
{
    [BsonElement("Public Debt for 2016")] public PublicDebt2016? PublicDebt2016 { get; set; }

    [BsonElement("Public Debt for 2017")] public PublicDebt2017? PublicDebt2017 { get; set; }
}

/// <summary>
///     PublicDebt2016 is a submodel of PublicDebt model.
/// </summary>
public class PublicDebt2016 : TextEntity
{
}

/// <summary>
///     PublicDebt2017 is a submodel of PublicDebt model.
/// </summary>
public class PublicDebt2017 : TextEntity
{
}