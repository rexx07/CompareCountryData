using System.Security;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace CompareCountries.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class SeedController : Controller
{
    private readonly IMongoCollection<> _dbContext;
    private readonly IWebHostEnvironment _env;

    public SeedController(CompareCountriesDbContext dbContext, IWebHostEnvironment env)
    {
        _dbContext = dbContext;
        _env = env;
    }

    public static void ProcessFilesInDir(string path)
    {
        string[] subdirectories = Directory.GetDirectories(path);
        
        
    }

    [HttpGet]
    public async  Task<IActionResult> ImportData()
    {
        if (!_env.IsDevelopment())
        {
            throw new SecurityException("Not Allowed");
        }

        var path = Path.Combine(_env.ContentRootPath, "Source");
        var subdirectories = Directory.GetDirectories(path);
        Dictionary<string, string[]> ContinentCountries = new Dictionary<string, string[]>();

        foreach (var dir in subdirectories)
        {
            var files = Directory.GetFiles(dir);
            ContinentCountries[dir] = files;
        }

        foreach (var key in ContinentCountries.Keys)
        {
            var filename = Path.GetFileName(key);
            filename = JsonSerializer.Deserialize<>()
        }
    }
}