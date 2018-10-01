using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    class Shop
    {
        List<Car> cars = new List<Car> { };
        List<Buyer> buyers = new List<Buyer> { };
        public Shop()
        {
            Console.WriteLine("Number of cars?");
            int n = Mass.check1();
            for (int i = 0; i < n; i++)
            {
                Add(cars);
            }
        }
        private void Add(List<Car> obj)
        {
            Car tmp = new Car();
            obj.Add(tmp);
        }
        private void Add(List<Buyer> obj)
        {
            Buyer tmp = new Buyer();
            obj.Add(tmp);
        }
        public void Add_car()
        {
            this.Add(this.cars);
        }
        public void Add_buyer()
        {
            Show();
            Console.WriteLine("Which car is buying?");
            int y = Mass.check1();
            Add(buyers);
            buyers[buyers.Count - 1].car = cars[y - 1];
            cars.Remove(cars[y - 1]);
        }
        public void Show()
        {
            if (cars.Count != 0)
                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine("Car №" + (i + 1));
                    cars[i].Show();
                }
            else
                Console.WriteLine("No cars");
        }
        public void Show_buyers()
        {
            if (buyers.Count != 0)
                for (int i = 0; i < buyers.Count; i++)
                {
                    Console.WriteLine("Buyer №" + (i + 1));
                    buyers[i].Show();
                }
            else
                Console.WriteLine("No buyers");
        }
        public void Check(int a, string t)
        {
            bool tk = false;
            for (int i = 0; i < cars.Count; i++)
            {
                if (a == 0)
                {
                    tk = cars[i].Check_b(t);
                }
                if (a == 1)
                {
                    tk = cars[i].Check_m(t);
                }
                if (a == 2)
                {
                    tk = cars[i].Check_n(t);
                }
                if (a == 3)
                {
                    tk = cars[i].Check_c(t);
                }
                if (tk)
                {
                    cars[i].Show();
                    return;
                }
            }
        }
    }
}
