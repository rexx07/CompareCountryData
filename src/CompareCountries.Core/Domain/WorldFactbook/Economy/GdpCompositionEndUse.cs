using System.ComponentModel;
using System.Runtime.CompilerServices;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Economy;

/// <summary>
/// GdpComposition is a submodel of Economy model.
/// </summary>
[DisplayName("GDP - composition, by end use")]
public class GdpCompositionEndUse
{
    [BsonElement("Export of goods and services")]
    public ExportsGandS ExportsGandS { get; set; }
    [BsonElement("Government consumption")]
    public GovernmentConsumption GovernmentConsumption { get; set; }
    [BsonElement("Household consumption")]
    public HouseholdConsumption HouseholdConsumption { get; set; }
    [BsonElement("Imports of goods and services")]
    public ImportGandS ImportGandS { get; set; }
    [BsonElement("Investment in fixed capital")]
    public InvestmentInFxdCap InvestmentInFxdCap { get; set; }
    [BsonElement("Investment in inventories")]
    public InvestmentInventories InvestmentInventories { get; set; }
}

/// <summary>
/// ExportGandS is a submodel of GdpCompositionEndUse model.
/// </summary>
public class ExportsGandS: TextEntity{}

/// <summary>
/// GovernmentConsumption is a submodel of GdpCompositionEndUse model.
/// </summary>
public class GovernmentConsumption: TextEntity{}

/// <summary>
/// HouseholdConsumption is a submodel of GdpCompositionEndUse model.
/// </summary>
public class HouseholdConsumption: TextEntity{}

/// <summary>
/// ImportGandS is a submodel of GdpCompositionEndUse model.
/// </summary>
public class ImportGandS: TextEntity{}

/// <summary>
/// InvestmentInFxdCap is a submodel of GdpCompositionEndUse model.
/// </summary>
public class InvestmentInFxdCap: TextEntity{}

/// <summary>
/// InvestmentInventories is a submodel of GdpCompositionEndUse model.
/// </summary>
public class InvestmentInventories: TextEntity{}