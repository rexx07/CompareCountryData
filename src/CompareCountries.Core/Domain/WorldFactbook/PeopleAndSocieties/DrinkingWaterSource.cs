using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     DrinkingWaterSource is a submodel of PeopleAndSociety model.
/// </summary>
public class DrinkingWaterSource
{
    [BsonElement("Improved : rural")] public ImprovedRural? ImprovedRural { get; set; }

    [BsonElement("Improved : total")] public ImprovedTotal? ImprovedTotal { get; set; }

    [BsonElement("Improved : Urban")] public ImprovedUrban? ImprovedUrban { get; set; }

    [BsonElement("Unimproved : rural")] public UnImprovedRural? UnImprovedRural { get; set; }

    [BsonElement("Unimproved : total")] public UnImprovedTotal? UnImprovedTotal { get; set; }

    [BsonElement("Unimproved : urban")] public UnImprovedUrban? UnImprovedUrban { get; set; }
}

/// <summary>
///     ImprovedRural is a submodel of DrinkingWaterSource model.
/// </summary>
public class ImprovedRural : TextEntity
{
}

/// <summary>
///     ImprovedTotal is a submodel of DrinkingWaterSource model.
/// </summary>
public class ImprovedTotal : TextEntity
{
}

/// <summary>
///     ImprovedUrban is a submodel of DrinkingWaterSource model.
/// </summary>
public class ImprovedUrban : TextEntity
{
}

/// <summary>
///     UnImprovedRural is a submodel of DrinkingWaterSource model.
/// </summary>
public class UnImprovedRural : TextEntity
{
}

/// <summary>
///     UnImprovedTotal is a submodel of DrinkingWaterSource model.
/// </summary>
public class UnImprovedTotal : TextEntity
{
}

/// <summary>
///     UnImprovedUrban is a submodel of DrinkingWaterSource model.
/// </summary>
public class UnImprovedUrban : TextEntity
{
}