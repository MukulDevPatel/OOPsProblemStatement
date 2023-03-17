using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OOPsProblemStatement.InventoryDataManagementProblem;

namespace OOPsProblemStatement.InventoryManagement
{
    public class InventoryDataManagement
    {
        public void ReadJsonFile(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            List<InventoryData> riceList = result.RiceList;
            Display(riceList);
            List<InventoryData> wheatList = result.WheatList;
            Display(wheatList);
            List<InventoryData> pulsesList = result.PulsesList;
            Display(pulsesList);
        }
        public void Display(List<InventoryData>list)
        {
            foreach (var inventory in list)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t" + inventory.PricePerKg + "\t" + inventory.Weight * inventory.PricePerKg);
            }
        }
    }
}
