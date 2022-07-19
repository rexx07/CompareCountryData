using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Government;

/// <summary>
/// NationalHeritage is a submodel of Government model.
/// </summary>
public class NationalHeritage
{
    [BsonElement("Selected world heritage site locales")]
    public SelWrldHeritageSiteLocales? SelWrldHeritageSiteLocales { get; set; }
    [BsonElement("Total world heritage site")]
    public TotalWrldHeritageSites? TotalWrldHeritageSites { get; set; }
}

/// <summary>
/// SelWrldHeritageSiteLocales is a submodel of NationalHeritage model.
/// </summary>
public class SelWrldHeritageSiteLocales: TextEntity{}

/// <summary>
/// TotalWrldHeritageSites is a submodel of NationalHeritage model.
/// </summary>
public class TotalWrldHeritageSites: TextEntity{}