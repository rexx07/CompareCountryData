using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     Exports is a submodel of Economy model.
/// </summary>
public class Exports
{
    [BsonElement("Export for 2016")] public Export2016? Export2016 { get; set; }

    [BsonElement("Export for 2017")] public Export2017? Export2017 { get; set; }

    [BsonElement("Export for 2018")] public Export2018? Export2018 { get; set; }

    [BsonElement("Export for 2019")] public Export2019? Export2019 { get; set; }

    [BsonElement("Export for 2020")] public Export2020? Export2020 { get; set; }
}

/// <summary>
///     Export2016 is a submodel for Exports model.
/// </summary>
public class Export2016 : TextEntity
{
}

/// <summary>
///     Export2017 is a submodel for Exports model.
/// </summary>
public class Export2017 : TextEntity
{
}

/// <summary>
///     Export2018 is a submodel for Exports model.
/// </summary>
public class Export2018 : TextEntity
{
}

/// <summary>
///     Export2019 is a submodel for Exports model.
/// </summary>
public class Export2019 : TextEntity
{
}

/// <summary>
///     Export2020 is a submodel for Exports model.
/// </summary>
public class Export2020 : TextEntity
{
}