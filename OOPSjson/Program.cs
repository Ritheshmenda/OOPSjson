using ObjectOrientedProgram.InventoryManagement;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        const string INVENTORY_JSON = @"C:\Users\Rithesh\source\repos\Object oriented programming\InventoryManagement\Inventory.json";
        static void Main(string[] args)
        {
            InventoryMain main = new InventoryMain();
            main.DisplayData(INVENTORY_JSON);
        }
    }
}