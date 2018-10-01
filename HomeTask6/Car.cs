using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    class Car
    {
        private string Model, Brand, Number, Color;
        private int price;
        public Car()
        {
            Console.WriteLine("Brand of car");
            Brand = Console.ReadLine();
            Console.WriteLine("Model of car");
            Model = Console.ReadLine();
            Console.WriteLine("Vehicle registration plate of car");
            Number = Console.ReadLine();
            Console.WriteLine("Color of car");
            Color = Console.ReadLine();
            Console.WriteLine("Price");
            price = Mass.check1();
        }
        public void Show()
        {
            Console.WriteLine("Brand of car:\t" + Brand);
            Console.WriteLine("Model of car:\t" + Model);
            Console.WriteLine("Vehicle registration plate of car:\t" + Number);
            Console.WriteLine("Color of car:\t" + Color);
            Console.WriteLine("Price:\t" + price);
        }
        public bool Check_m(string c)
        {
            if (c == this.Model)
            {
                return true;
            }
            return false;
        }
        public bool Check_b(string c)
        {
            if (c == this.Brand)
            {
                return true;
            }
            return false;
        }

        public bool Check_c(string c)
        {
            if (c == this.Color)
            {
                return true;
            }
            return false;
        }
        public bool Check_n(string c)
        {
            if (c == this.Number)
            {
                return true;
            }
            return false;
        }
    }
}
