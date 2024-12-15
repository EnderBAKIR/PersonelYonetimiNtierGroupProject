using Microsoft.Extensions.Configuration;
using System.IO;

public class JsonConfigReader
{
    public static IConfiguration Configuration { get; set; }

    static JsonConfigReader()
    {
        // Configuration'ı başlatmak için dosya yolu
        Configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())  // Ya da Application.StartupPath
            .AddJsonFile("database.json", optional: false, reloadOnChange: true)
            .Build();
    }

    // Connection string'i almak
    public static string GetConnectionString(string name)
    {
        return Configuration.GetConnectionString(name);
    }
}
