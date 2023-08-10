using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Xml;

namespace UpdateAppSettings.Controllers
{
    public class UpdateConnection
    {
        public static void Atualiza()
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                          .AddJsonFile("appsettings.json")
                                                          .Build();

            string currentConnectionString = configuration.GetConnectionString("DefaultConnection");
            string newConnectionString = "NovaConnectionString...";

            var json = File.ReadAllText("appsettings.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            jsonObj["ConnectionStrings"]["DefaultConnection"] = newConnectionString;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("appsettings.json", output);
        }
    }
}
