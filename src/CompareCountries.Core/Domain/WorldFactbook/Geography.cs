namespace CompareCountries.Core.Domain.WorldFactbook;

public class Geography: BaseEntity
{
    public string Location { get; set; }
    public string GeographicCoordinate { get; set; }
    public string MapReferences { get; set; }
    public string Area { get; set; }
    public string AreaComparative { get; set; }
    public string LandBoundaries { get; set; }
    public string CoastLine { get; set; }
    public string MaritimeClaims { get; set; }
    public string Climate { get; set; }
    public string Terrain { get; set; }
    public string Elevation { get; set; }
    public string NaturalResources { get; set; }
    public string LandUse { get; set; }
    public string IrrigatedLand { get; set; }
    public string MajorWatersheds { get; set; }
    public string MajorAquifers { get; set; }
    public string PopulationDistribution { get; set; }
    public string NaturalHazards { get; set; }
    public string MapDescription { get; set; }
    public string GeographyNote { get; set; }
}