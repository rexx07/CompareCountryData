using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;

namespace CompareCountries.Core.Domain;

[DisplayName("content of the field in string format")]
public class TextEntity
{
    [BsonElement("text")] public string? Text { get; set; }
}