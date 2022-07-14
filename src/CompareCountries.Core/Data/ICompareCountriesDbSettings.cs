namespace CompareCountries.Core.Data;

public interface ICompareCountriesDbSettings
{
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
    string WorldCollectionName { get; set; }
}