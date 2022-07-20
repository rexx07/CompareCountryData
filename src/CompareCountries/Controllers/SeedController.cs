using System.Security;
using CompareCountries.Core.Data;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace CompareCountries.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class SeedController : Controller
{
    private readonly IWebHostEnvironment _env;
    private readonly IMongoCollection<BsonDocument[]> _worldFactbookCollection;

    public SeedController(ICompareCountriesDbSettings settings, IWebHostEnvironment env)
    {
        _env = env;
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);
        _worldFactbookCollection = database.GetCollection<BsonDocument[]>(settings.WorldCollectionName);
    }


    [HttpGet]
    public async Task<IActionResult> ImportData()
    {
        if (!_env.IsDevelopment()) throw new SecurityException("Not Allowed");

        /*var documentAdded = 0;
        var path2 = Path.Combine(_env.ContentRootPath, @"Source\worldfactbook.json");
        
        using (var streamReader = new StreamReader(path2))
        {
            string? line;
            while ((line = await streamReader.ReadLineAsync()) != null)
            {
                using (var jsonReader = new JsonReader(line))
                {
                    var context = BsonDeserializationContext.CreateRoot(jsonReader);
                            
                    var document = _worldFactbookCollection.DocumentSerializer
                        .Deserialize(context);
                    await _worldFactbookCollection.InsertOneAsync(document);
                    documentAdded++;
                }
            }
        }*/
        var path = Path.Combine(_env.ContentRootPath, "Source");
        var subdirectories = Directory.GetDirectories(path);
        var continentCountries = new Dictionary<string, string[]>();
        var documentAdded = 0;

        foreach (var dir in subdirectories)
        {
            var files = Directory.GetFiles(dir);
            continentCountries[dir] = files;
        }

        var allValues = continentCountries.Values;

        foreach (var values in allValues)
        foreach (var value in values)
            using (var streamReader = new StreamReader(path))
            {
                string? line;
                while ((line = await streamReader.ReadLineAsync()) != null)
                    using (var jsonReader = new JsonReader(line))
                    {
                        var context = BsonDeserializationContext.CreateRoot(jsonReader);

                        var document = _worldFactbookCollection.DocumentSerializer
                            .Deserialize(context);
                        await _worldFactbookCollection.InsertOneAsync(document);
                        documentAdded++;
                    }
            }

        return new JsonResult(new
        {
            documentAdded
        });
    }
}