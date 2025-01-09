using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpplusSample.Models
{
    public class MapColumnCollection
    {
        private const string FileName = "MapColumnsFileWithType.json";

        public GenericMapping GetRulesFromFile(string binPath, string objectName)
        {
            var text = File.ReadAllText($@"{binPath}/{objectName}_{FileName}");
            var mapRules = JsonConvert.DeserializeObject<GenericMapping>(text);
            return mapRules;
        }

        public void SaveToFile(string filePath, GenericMapping mapRules)
        {
            if (mapRules!=null && mapRules.MapRules.Any())
            {
                string json = JsonConvert.SerializeObject(mapRules, Formatting.Indented);
                File.WriteAllText($@"{filePath}/{FileName}", json);
            }
        }
    }
}
