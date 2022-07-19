using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// Credit ratings is a submodel under Economy model
/// </summary>
public class CreditRatings
{
    [BsonElement("Fitch rating")]
    public FitchRating? FitchRating { get; set; }
    [BsonElement("Moody's rating")]
    public MoodysRating? MoodysRating { get; set; }
    [BsonElement("Standard & Poors Rating")]
    public StandardAndPoorsRating? StandardAndPoorsRating { get; set; }
}

/// <summary>
/// Fitch rating is a submodel under Credit ratings model.
/// </summary>
public class FitchRating: TextEntity{}

/// <summary>
/// Moody's rating is a submodel under Credit ratings model
/// </summary>
public class MoodysRating: TextEntity{}

/// <summary>
/// StandardAndPoorsRating is a submodel under Credit ratings model.
/// </summary>
public class StandardAndPoorsRating: TextEntity{}