using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     DiplomaticRepresentationInUs is a submodel of Government model.
/// </summary>
[DisplayName("Diplomatic response In the US")]
public class DiplomaticRepresentationInUs
{
    [BsonElement("FAX")] public FaxInUs? FaxInUs { get; set; }

    [BsonElement("Chancery")] public Chancery? Chancery { get; set; }

    [BsonElement("Chief of mission")] public ChiefOfMissionInUs? ChiefOfMissionInUs { get; set; }

    [BsonElement("Consulate(s)")] public Consulate? Consulate { get; set; }

    [BsonElement("Consulate(s) general")] public ConsulateGeneral? ConsulateGeneral { get; set; }

    [BsonElement("Email address and website")]
    public EmailAddressAndWebsiteInUs? EmailAddressAndWebsiteInUs { get; set; }

    [BsonElement("Representative office")] public RepresentativeOffice? RepresentativeOffice { get; set; }

    [BsonElement("Telephone")] public TelephoneInUs? TelephoneInUs { get; set; }
}

/// <summary>
///     FaxInUs is a submodel of DiplomaticRepresentationInUs model.
/// </summary>
public class FaxInUs : TextEntity
{
}

/// <summary>
///     Chancery is a submodel of DiplomaticRepresentationInUs model.
/// </summary>
public class Chancery : TextEntity
{
}

/// <summary>
///     ChiefOfMissionInUs is a submodel of DiplomaticRepresentationInUs model.
/// </summary>
public class ChiefOfMissionInUs : TextEntity
{
}

/// <summary>
///     Consulate is a submodel of DiplomaticRepresentationInUs model.
/// </summary>
public class Consulate : TextEntity
{
}

/// <summary>
///     ConsulateGeneral is a submodel of DiplomaticRepresentationInUs model.
/// </summary>
public class ConsulateGeneral : TextEntity
{
}

/// <summary>
///     EmailAddressAndWebsiteInUs is a submodel of DiplomaticRepresentationInUs model.
/// </summary>
public class EmailAddressAndWebsiteInUs : TextEntity
{
}

/// <summary>
///     RepresentativeOffice is a submodel of DiplomaticRepresentationInUs model.
/// </summary>
public class RepresentativeOffice : TextEntity
{
}

/// <summary>
///     TelephoneInUs is a submodel of DiplomaticRepresentationInUs
/// </summary>
public class TelephoneInUs : TextEntity
{
}