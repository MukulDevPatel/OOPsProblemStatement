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
        List<InventoryData> riceList;
        List<InventoryData> wheatList;
        List<InventoryData> pulsesList;
        public void ReadJsonFile(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            riceList = result.RiceList;
            Display(riceList);
            wheatList = result.WheatList;
            Display(wheatList);
            pulsesList = result.PulsesList;
            Display(pulsesList);
        }
        public void Display(List<InventoryData> list)
        {
            foreach (var inventory in list)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t" + inventory.PricePerKg + "\t" + inventory.Weight * inventory.PricePerKg);
            }
        }
        public void AddInventory()
        {
            Console.WriteLine("Enter in which list new ineventory need to be added");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Inventory Data");
            InventoryData data = new InventoryData();
            data.Name = Console.ReadLine();
            data.Weight = Convert.ToDouble(Console.ReadLine());
            data.PricePerKg = Convert.ToDouble(Console.ReadLine());
            if (name.ToLower().Equals("rice"))
            { 
                riceList.Add(data); 
            }
            if (name.ToLower().Equals("wheat"))
            {
                wheatList.Add(data);
            }
            if (name.ToLower().Equals("pulses"))
            {
               pulsesList.Add(data);
            }
        }
        
    }
}
