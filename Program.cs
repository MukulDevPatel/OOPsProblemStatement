using OOPsProblemStatement.InventoryDataManagementProblem;
using OOPsProblemStatement.InventoryManagement;
using System;
namespace OOPsProblemStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Data Management Base");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select option for execution\n1. Data Management\n2. Inventory Data List\n3. Add Inventory\n4. Exit");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        InventoryOperation inventory = new InventoryOperation();
                        inventory.ReadJsonFile(@"D:\BridgeLabz\OOPsProblemStatement\InventoryDataManagementProblem\Inventory.json");
                        break;
                    case 2:
                        InventoryDataManagement inventor = new InventoryDataManagement();
                        inventor.ReadJsonFile(@"D:\BridgeLabz\OOPsProblemStatement\InventoryManagement\InventoryDetails.json");
                        break;
                    case 3:
                        InventoryDataManagement addInventory = new InventoryDataManagement();
                        addInventory.ReadJsonFile(@"D:\BridgeLabz\OOPsProblemStatement\InventoryManagement\InventoryDetails.json");
                        addInventory.AddInventory();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
