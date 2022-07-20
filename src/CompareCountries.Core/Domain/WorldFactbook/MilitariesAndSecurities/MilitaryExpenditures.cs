using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.MilitariesAndSecurities;

/// <summary>
///     MilitaryExpenditures is a submodel of MilitaryAndSecurity model.
/// </summary>
public class MilitaryExpenditures
{
    [BsonElement("Military expenditures 2016")]
    public MilitaryExpenditures2016? MilitaryExpenditures2016 { get; set; }

    [BsonElement("Military expenditures 2017")]
    public MilitaryExpenditures2017? MilitaryExpenditures2017 { get; set; }

    [BsonElement("Military expenditures 2018")]
    public MilitaryExpenditures2018? MilitaryExpenditures2018 { get; set; }

    [BsonElement("Military expenditures 2019")]
    public MilitaryExpenditures2019? MilitaryExpenditures2019 { get; set; }

    [BsonElement("Military expenditures 2020")]
    public MilitaryExpenditures2020? MilitaryExpenditures2020 { get; set; }

    [BsonElement("Military expenditures 2021")]
    public MilitaryExpenditures2021? MilitaryExpenditures2021 { get; set; }
}

/// <summary>
///     MilitaryExpenditures2016 is a submodel of MilitaryExpenditures model.
/// </summary>
public class MilitaryExpenditures2016 : TextEntity
{
}

/// <summary>
///     MilitaryExpenditures2017 is a submodel of MilitaryExpenditures model.
/// </summary>
public class MilitaryExpenditures2017 : TextEntity
{
}

/// <summary>
///     MilitaryExpenditures2018 is a submodel of MilitaryExpenditures model.
/// </summary>
public class MilitaryExpenditures2018 : TextEntity
{
}

/// <summary>
///     MilitaryExpenditures2019 is a submodel of MilitaryExpenditures model.
/// </summary>
public class MilitaryExpenditures2019 : TextEntity
{
}

/// <summary>
///     MilitaryExpenditures2020 is a submodel of MilitaryExpenditures model.
/// </summary>
public class MilitaryExpenditures2020 : TextEntity
{
}

/// <summary>
///     MilitaryExpenditures2021 is a submodel of MilitaryExpenditures model.
/// </summary>
public class MilitaryExpenditures2021 : TextEntity
{
}