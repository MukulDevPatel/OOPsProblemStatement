using OOPsProblemStatement.InventoryDataManagementProblem;
using System;
namespace OOPsProblemStatement
{
    class Program
    {
        static void Main(string[] args)
        {
           InventoryOperation inventory = new InventoryOperation();
            inventory.ReadJsonFile(@"D:\BridgeLabz\Demo\OOPsProblemStatement\InventoryDataManagementProblem\Inventory.json");
        }
    }
}
