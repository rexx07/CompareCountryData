namespace CompareCountries.Core.Data;

public class CompareCountriesDbSettings: ICompareCountriesDbSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string WorldCollectionName { get; set; } = null!;
}