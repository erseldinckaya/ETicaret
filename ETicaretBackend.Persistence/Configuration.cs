using Microsoft.Extensions.Configuration;

namespace ETicaretBackend.Persistence;

static class Configuration
{
    static public string ConnectionString
    {
        get
        {
            //Prensetation katmanında json dosyasında tanımladığımız connection stringi almamızı sağlıyor.
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),
                "../../Presentation/ETicaretBackend.API"));
            configurationManager.AddJsonFile("appsettings.json");
            return configurationManager.GetConnectionString("PostgreSQL");
        }
    }
}