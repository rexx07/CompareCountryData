using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.PeopleAndSocieties;

/// <summary>
///     SanitationFacilityAccess is a submoel of PeopleAndSociety model.
/// </summary>
public class SanitationFacilityAccess
{
    [BsonElement("Improved : rural")] public ImprovedRuralSanFacAcc? ImprovedRuralSanFacAcc { get; set; }

    [BsonElement("Improved : total")] public ImprovedTotalSanFacAcc? ImprovedTotalSanFacAcc { get; set; }

    [BsonElement("Improved : Urban")] public ImprovedUrbanSanFacAcc? ImprovedUrbanSanFacAcc { get; set; }

    [BsonElement("Unimproved : rural")] public UnImprovedRuralSanFacAcc? UnImprovedRuralSanFacAcc { get; set; }

    [BsonElement("Unimproved : total")] public UnImprovedTotalSanFacAcc? UnImprovedTotalSanFacAcc { get; set; }

    [BsonElement("Unimproved : urban")] public UnImprovedUrbanSanFacAcc? UnImprovedUrbanSanFacAcc { get; set; }
}

/// <summary>
///     ImprovedRuralSanFacAcc is a submodel of SanitationFacilityAccess model.
/// </summary>
public class ImprovedRuralSanFacAcc : TextEntity
{
}

/// <summary>
///     ImprovedTotalSanFacAcc is a submodel of SanitationFacilityAccess model.
/// </summary>
public class ImprovedTotalSanFacAcc : TextEntity
{
}

/// <summary>
///     ImprovedUrbanSanFacAcc is a submodel of SanitationFacilityAccess model.
/// </summary>
public class ImprovedUrbanSanFacAcc : TextEntity
{
}

/// <summary>
///     UnImprovedRuralSanFacAcc is a submodel of SanitationFacilityAccess model.
/// </summary>
public class UnImprovedRuralSanFacAcc : TextEntity
{
}

/// <summary>
///     UnImprovedTotalSanFacAcc is a submodel of DrinkingWaterSource model.
/// </summary>
public class UnImprovedTotalSanFacAcc : TextEntity
{
}

/// <summary>
///     UnImprovedUrbanSanFacAcc is a submodel of SanitationFacilityAccess model.
/// </summary>
public class UnImprovedUrbanSanFacAcc : TextEntity
{
}