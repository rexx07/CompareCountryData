using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     DiplomaticRepresentationFromUs is a submodel of Government model.
/// </summary>
[DisplayName("Diplomatic response from the US")]
public class DiplomaticRepresentationFromUs
{
    [BsonElement("FAX")] public Fax? Fax { get; set; }

    [BsonElement("Branch offices(s)")] public BranchOfficesFromUs? BranchOffices { get; set; }

    [BsonElement("Chief of mission")] public ChiefOfMissionFromUs? ChiefOfMission { get; set; }

    [BsonElement("Email address and website")]
    public EmailAddressAndWebsiteFromUs? EmailAddressAndWebsite { get; set; }

    [BsonElement("Embassy")] public Embassy? Embassy { get; set; }

    [BsonElement("Mailing address")] public MailingAddress? MailingAddress { get; set; }

    [BsonElement("FAX")] public TelephoneFromUs? Telephone { get; set; }
}

/// <summary>
///     Fax is a submodel of DiplomaticRepresentationFromUs model.
/// </summary>
public class Fax : TextEntity
{
}

/// <summary>
///     BranchOfficesFromUs is a submodel of DiplomaticRepresentationFromUs model.
/// </summary>
public class BranchOfficesFromUs : TextEntity
{
}

/// <summary>
///     ChiefOfMissionFromUs is a submodel of DiplomaticRepresentationFromUs model.
/// </summary>
public class ChiefOfMissionFromUs : TextEntity
{
}

/// <summary>
///     EmailAddressAndWebsiteFromUs is a submodel of DiplomaticRepresentationFromUs model.
/// </summary>
public class EmailAddressAndWebsiteFromUs : TextEntity
{
}

/// <summary>
///     Embassy is a submodel of DiplomaticRepresentationFromUs model.
/// </summary>
public class Embassy : TextEntity
{
}

/// <summary>
///     MailingAddress is a submodel of DiplomaticRepresentationFromUs model.
/// </summary>
public class MailingAddress : TextEntity
{
}

/// <summary>
///     TelephoneFromUs is a submodel of DiplomaticRepresentationFromUs model.
/// </summary>
public class TelephoneFromUs : TextEntity
{
}