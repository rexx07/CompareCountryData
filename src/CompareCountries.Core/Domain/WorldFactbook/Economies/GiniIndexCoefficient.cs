using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economies;

/// <summary>
///     GiniIndexCoefficient is a submodel of Economy model.
/// </summary>
[DisplayName("Gini index coefficient - distribution of family income")]
public class GiniIndexCoefficient
{
    [BsonElement("Gini index coefficient - distribution of family income 1993")]
    public GiniIndexCoefficient1993? GiniIndexCoefficient1993 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2011")]
    public GiniIndexCoefficient2011? GiniIndexCoefficient2011 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2012")]
    public GiniIndexCoefficient2012? GiniIndexCoefficient2012 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2013")]
    public GiniIndexCoefficient2013? GiniIndexCoefficient2013 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2014")]
    public GiniIndexCoefficient2014? GiniIndexCoefficient2014 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2015")]
    public GiniIndexCoefficient2015? GiniIndexCoefficient2015 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2016")]
    public GiniIndexCoefficient2016? GiniIndexCoefficient2016 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2017")]
    public GiniIndexCoefficient2017? GiniIndexCoefficient2017 { get; set; }

    [BsonElement("Gini index coefficient - distribution of family income 2018")]
    public GiniIndexCoefficient2018? GiniIndexCoefficient2018 { get; set; }
}

/// <summary>
///     GiniIndexCoefficient1993 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient1993 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient2011 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2011 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient2012 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2012 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient2013 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2013 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient2014 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2014 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient2015 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2015 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient2016 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2016 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient2017 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2017 : TextEntity
{
}

/// <summary>
///     GiniIndexCoefficient1993 is a submodel of GiniIndexCoefficient model.
/// </summary>
public class GiniIndexCoefficient2018 : TextEntity
{
}