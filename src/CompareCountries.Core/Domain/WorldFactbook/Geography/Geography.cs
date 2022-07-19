using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain.WorldFactbook.Geography;

public class Geography: BaseEntity
{
    [BsonElement("Area")]
    public Area? Area { get; set; }
    [BsonElement("Area - comparative")]
    public AreaComparative? AreaComparative { get; set; }
    [BsonElement("Climate")]
    public Climate? Climate { get; set; }
    [BsonElement("Coastline")]
    public Coastline? Coastline { get; set; }
    [BsonElement("Elevation")]
    public Elevation? Elevation { get; set; }
    [BsonElement("Geographic coordinates")]
    public GeographicCoordinates? GeographicCoordinates { get; set; }
    [BsonElement("Geography - note")]
    public GeographyNote? GeographyNote { get; set; }
    [BsonElement("Irrigated land")]
    public IrrigatedLand? IrrigatedLand { get; set; }
    [BsonElement("Land boundaries")]
    public LandBoundaries? LandBoundaries { get; set; }
    [BsonElement("Land use")]
    public LandUse? LandUse { get; set; }
    [BsonElement("Location")]
    public Location? Location { get; set; }
    [BsonElement("Major aquifers")]
    public MajorAquifers? MajorAquifers { get; set; }
    [BsonElement("Major lakes (area sq km)")]
    public MajorLakes? MajorLakes { get; set; }
    [BsonElement("Major Rivers (by length in km)")]
    public MajorRivers? MajorRivers { get; set; }
    [BsonElement("Major watersheds (area sq km)")]
    public MajorWatersheds? MajorWatersheds { get; set; }
    [BsonElement("Map description")]
    public MapDescription? MapDescription { get; set; }
    [BsonElement("Map references")]
    public MapReferences? MapReferences { get; set; }
    [BsonElement("Maritime claims")]
    public MaritimeClaims? MaritimeClaims { get; set; }
    [BsonElement("Natural hazards")]
    public NaturalHazards? NaturalHazards { get; set; }
    [BsonElement("Natural Resources")]
    public NaturalResources? NaturalResources { get; set; }
    [BsonElement("Population distribution")]
    public PopulationDistribution? PopulationDistribution { get; set; }
    [BsonElement("Terrain")]
    public Terrain? Terrain { get; set; }
}