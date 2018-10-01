using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    class Buyer
    {
        public Car car;
        string Fname;
        string Lname;
        public Buyer()
        {
            Console.WriteLine("Enter First name");
            Fname = Console.ReadLine();
            Console.WriteLine("Enter Last name");
            Lname = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("First name:\t" + Fname);
            Console.WriteLine("Last name:\t" + Lname);
            car.Show();
        }
    }
}
