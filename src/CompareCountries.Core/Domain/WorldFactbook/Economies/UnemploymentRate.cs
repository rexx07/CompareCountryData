using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     UnemploymentRate is a submodel of Economy model.
/// </summary>
public class UnemploymentRate : TextEntity
{
    [BsonElement("Unemployment rate 2001")]
    public UnemploymentRate2001? UnemploymentRate2001 { get; set; }

    [BsonElement("Unemployment rate 2009")]
    public UnemploymentRate2009? UnemploymentRate2009 { get; set; }

    [BsonElement("Unemployment rate 2013")]
    public UnemploymentRate2013? UnemploymentRate2013 { get; set; }

    [BsonElement("Unemployment rate 2014")]
    public UnemploymentRate2014? UnemploymentRate2014 { get; set; }

    [BsonElement("Unemployment rate 2016")]
    public UnemploymentRate2016? UnemploymentRate2016 { get; set; }

    [BsonElement("Unemployment rate 2017")]
    public UnemploymentRate2017? UnemploymentRate2017 { get; set; }
}

/// <summary>
///     UnemploymentRate2001 is a submodel of UnemploymentRate model.
/// </summary>
public class UnemploymentRate2001 : TextEntity
{
}

/// <summary>
///     UnemploymentRate2009 is a submodel of UnemploymentRate model.
/// </summary>
public class UnemploymentRate2009 : TextEntity
{
}

/// <summary>
///     UnemploymentRate2013 is a submodel of UnemploymentRate model.
/// </summary>
public class UnemploymentRate2013 : TextEntity
{
}

/// <summary>
///     UnemploymentRate2014 is a submodel of UnemploymentRate model.
/// </summary>
public class UnemploymentRate2014 : TextEntity
{
}

/// <summary>
///     UnemploymentRate2016 is a submodel of UnemploymentRate model.
/// </summary>
public class UnemploymentRate2016 : TextEntity
{
}

/// <summary>
///     UnemploymentRate2017 is a submodel of UnemploymentRate model.
/// </summary>
public class UnemploymentRate2017 : TextEntity
{
}