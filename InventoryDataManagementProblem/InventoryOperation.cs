using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace OOPsProblemStatement.InventoryDataManagementProblem
{
    public class InventoryOperation
    {
        public void ReadJsonFile(string filePath)
        {
            //Deserialization - Conversion of data from Json format to string format
            //Serialization - Conversion of data from string format to Json format
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<List<InventoryData>>(data);
            foreach (var inventory in result)
            {
                Console.WriteLine(inventory.Name+"\t"+inventory.Weight+"\t"+inventory.PricePerKg+"\t"+inventory.Weight*inventory.PricePerKg);
           }
        }
    }
}
