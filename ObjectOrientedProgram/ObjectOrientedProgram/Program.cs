using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            InventoryData id = new InventoryData();
            
            while (flag)
            {
                Console.WriteLine("enter your choice 1-Display data,2-Stock Data,3-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        id.Data(@"E:\ObjectOrientedPrograms\ObjectOrientedProgram\ObjectOrientedProgram\File\Inventory.json");
                        string state = Convert.ToString(Console.ReadLine());
                        id.Display(state);
                        break;
                    case 2:
                        StockMain main = new StockMain();
                        main.StockData(@"E:\ObjectOrientedPrograms\ObjectOrientedProgram\ObjectOrientedProgram\File\Stock.json");
                        break;

                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
