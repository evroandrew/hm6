using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo gb;
            Shop obj = new Shop();
            do
            {
                Console.Clear();
                Console.WriteLine("Enter 1 to show cars ");
                Console.WriteLine("Enter 2 to add car ");
                Console.WriteLine("Enter 3 to check if there is a car ");
                Console.WriteLine("Enter 4 to show buyers ");
                Console.WriteLine("Enter 5 to add buyer ");
                Console.WriteLine("Enter 0 to exit");
                gb = Console.ReadKey();
                Console.Clear();
                if (gb.Key == ConsoleKey.NumPad1)
                    obj.Show();
                if (gb.Key == ConsoleKey.NumPad2)
                    obj.Add_car();
                if (gb.Key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine("to check availability of brand enter 1");
                    Console.WriteLine("to check availability of model enter 2");
                    Console.WriteLine("to check availability of number enter 3");
                    Console.WriteLine("to check availability of color enter 4");
                    int n = Mass.check1();
                    Console.WriteLine("Enter parameter");
                    string str = Console.ReadLine();
                    obj.Check(n, str);
                }
                if (gb.Key == ConsoleKey.NumPad4)
                    obj.Show_buyers();
                if (gb.Key == ConsoleKey.NumPad5)
                    obj.Add_buyer();
                if (gb.Key != ConsoleKey.NumPad0)
                    Console.ReadKey();
                else
                    return;
            } while (gb.Key != ConsoleKey.NumPad0);
            Console.ReadKey();
        }
    }
}
