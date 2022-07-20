namespace CompareCountries.Core.Domain.WorldFactbook.Governments;

/// <summary>
///     CountryName is a submodel of Government model.
/// </summary>
public class CountryName : ExtraNote
{
}

/// <summary>
///     Abbreviation is a submodel of CountryName model.
/// </summary>
public class Abbreviation : TextEntity
{
}

/// <summary>
///     ConventionalLongForm is a submodel of CountryName model.
/// </summary>
public class ConventionalLongForm : TextEntity
{
}

/// <summary>
///     ConventionalShortForm is a submodel of CountryName model.
/// </summary>
public class ConventionalShortForm : TextEntity
{
}

/// <summary>
///     EtymologyCountryName is a submodel of CountryName model.
/// </summary>
public class EtymologyCountryName : TextEntity
{
}

/// <summary>
///     Former is a submodel of CountryName model.
/// </summary>
public class Former : TextEntity
{
}

/// <summary>
///     LocalLongForm is a submodel of CountryName model.
/// </summary>
public class LocalLongForm : TextEntity
{
}

/// <summary>
///     LocalShortForm is a submodel of CountryName model.
/// </summary>
public class LocalShortForm : TextEntity
{
}