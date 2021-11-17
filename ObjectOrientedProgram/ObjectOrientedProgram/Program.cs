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
                Console.WriteLine("enter your choice 1-Display data,2-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        id.DisplayData(@"E:\ObjectOrientedPrograms\ObjectOrientedProgram\ObjectOrientedProgram\File\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
