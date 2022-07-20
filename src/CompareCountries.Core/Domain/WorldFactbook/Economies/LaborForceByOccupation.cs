using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     LaborForceByOccupation is a submodel of Economy model.
/// </summary>
public class LaborForceByOccupation
{
    [BsonElement("Agriculture Labor Force")]
    public AgricultureLB? AgricultureLb { get; set; }

    [BsonElement("Industry Labor Force")] public IndustryLB? IndustryLb { get; set; }

    [BsonElement("Industry and services Labor Force")]
    public IndustryAndServicesLB? IndustryAndServicesLB { get; set; }

    [BsonElement("Services Labor Force")] public ServicesLB? ServicesLb { get; set; }
}

/// <summary>
///     AgricultureLB is a submodel of LaborForcesByOccupation model.
/// </summary>
public class AgricultureLB : TextEntity
{
}

/// <summary>
///     IndustryLB is a submodel of LaborForcesByOccupation model.
/// </summary>
public class IndustryLB : TextEntity
{
}

/// <summary>
///     IndustryAndServicesLB is a submodel of LaborForcesByOccupation model.
/// </summary>
public class IndustryAndServicesLB : TextEntity
{
}

/// <summary>
///     ServicesLB is a submodel of LaborForcesByOccupation model.
/// </summary>
public class ServicesLB : TextEntity
{
}