using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     DebtExternal is a submodel of Economy model.
/// </summary>
public class DebtExternal
{
    [BsonElement("Debt - external 2016")] public DebtExternal2016? DebtExternal2016 { get; set; }

    [BsonElement("Debt - external 2017")] public DebtExternal2017? DebtExternal2017 { get; set; }

    [BsonElement("Debt - external 2018")] public DebtExternal2018? DebtExternal2018 { get; set; }

    [BsonElement("Debt - external 2019")] public DebtExternal2019? DebtExternal2019 { get; set; }
}

/// <summary>
///     DebtExternal2016 is a submodel of DebtExternal model.
/// </summary>
public class DebtExternal2016 : TextEntity
{
}

/// <summary>
///     DebtExternal2017 is a submodel of DebtExternal model.
/// </summary>
public class DebtExternal2017 : TextEntity
{
}

/// <summary>
///     DebtExternal2018 is a submodel of DebtExternal model.
/// </summary>
public class DebtExternal2018 : TextEntity
{
}

/// <summary>
///     DebtExternal2019 is a submodel of DebtExternal model.
/// </summary>
public class DebtExternal2019 : TextEntity
{
}