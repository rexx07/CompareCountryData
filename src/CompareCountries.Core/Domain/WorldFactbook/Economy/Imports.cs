using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// Imports Model is a submodel of Economy model.
/// </summary>
public class Imports
{
    [BsonElement("Imports 2016")]
    public Imports2016 Imports2016 { get; set; }
    [BsonElement("Imports 2017")]
    public Imports2017 Imports2017 { get; set; }
    [BsonElement("Imports 2018")]
    public Imports2018 Imports2018 { get; set; }
    [BsonElement("Imports 2019")]
    public Imports2019 Imports2019 { get; set; }
    [BsonElement("Imports 2016")]
    public Imports2020 Imports2020 { get; set; }
}

/// <summary>
/// Imports2016 is a submodel of Imports model.
/// </summary>
public class Imports2016: TextEntity{}

/// <summary>
/// Imports2017 is a submodel of Imports model.
/// </summary>
public class Imports2017: TextEntity{}

/// <summary>
/// Imports2018 is a submodel of Imports model.
/// </summary>
public class Imports2018: TextEntity{}

/// <summary>
/// Imports2019 is a submodel of Imports model.
/// </summary>
public class Imports2019: TextEntity{}

/// <summary>
/// Imports2020 is a submodel of Imports model.
/// </summary>
public class Imports2020: TextEntity{}