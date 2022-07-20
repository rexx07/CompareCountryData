using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     ExchangeRate is a submodel of Economy model.
/// </summary>
public class ExchangeRates
{
    [BsonElement("Exchange Rate for 2013")]
    public ExchangeRates2013? ExchangeRates2013 { get; set; }

    [BsonElement("Exchange Rate for 2014")]
    public ExchangeRates2014? ExchangeRates2014 { get; set; }

    [BsonElement("Exchange Rate for 2015")]
    public ExchangeRates2015? ExchangeRates2015 { get; set; }

    [BsonElement("Exchange Rate for 2016")]
    public ExchangeRates2016? ExchangeRates2016 { get; set; }

    [BsonElement("Exchange Rate for 2017")]
    public ExchangeRates2017? ExchangeRates2017 { get; set; }

    [BsonElement("Exchange Rate for 2018")]
    public ExchangeRates2018? ExchangeRates2018 { get; set; }

    [BsonElement("Exchange Rate for 2019")]
    public ExchangeRates2019? ExchangeRates2019 { get; set; }

    [BsonElement("Exchange Rate for 2020")]
    public ExchangeRates2020? ExchangeRates2020 { get; set; }
}

/// <summary>
///     ExchangeRate2013 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2013 : TextEntity
{
}

/// <summary>
///     ExchangeRate2014 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2014 : TextEntity
{
}

/// <summary>
///     ExchangeRate2015 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2015 : TextEntity
{
}

/// <summary>
///     ExchangeRate2016 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2016 : TextEntity
{
}

/// <summary>
///     ExchangeRate2017 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2017 : TextEntity
{
}

/// <summary>
///     ExchangeRate2018 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2018 : TextEntity
{
}

/// <summary>
///     ExchangeRate2019 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2019 : TextEntity
{
}

/// <summary>
///     ExchangeRate2020 is a submodel of ExchangeRate
/// </summary>
public class ExchangeRates2020 : TextEntity
{
}