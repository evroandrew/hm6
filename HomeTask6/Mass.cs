using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    class Mass
    {
        private static Random rng;
        private enum MyWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }
        public void what_day()
        {
            int day = GetInt("Введите день месяца =>");
            int month = GetInt("Введите месяц (1-январь) =>");
            int year = GetInt("Введите год =>");
            //Преобразуем дату в юлианский календарь
            if (month == 1 || month == 2)
            {
                --year;
            }
            month -= 2;
            if (month < 0)
            {
                month += 12;
            }
            int c = year / 100;
            year %= 100;
            int dayOfWeek = (day + (13 * month - 1) / 5 + year + year / 4 + c / 4 - 2 * c + 777) % 7;
            Console.WriteLine((MyWeek)(dayOfWeek));
        }
        public void arr_f(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
        }
        public void Shuffle(int[] arr)
        {
            rng = new Random();
            int n = arr.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = arr[k];
                arr[k] = arr[n];
                arr[n] = value;
            }
        }
        public void show_mass(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static int check1()
        {
            for (; ; )
            {
                Console.Write(" : __\b\b");
                string str = Console.ReadLine();
                int a1 = 0;
                if ((!Int32.TryParse(str, out a1)) | (a1 < 0))
                {
                    Console.WriteLine("Try again...");
                }
                else
                    return a1;
            }
        }
        public double agc(int a, int i, int d, int k)
        {
            double ags = Math.Sin(2 * Math.PI * (d + i) / a) * (k);
            return ags;
        }
        public double check_num(double num)
        {
            double num1 = Math.Round(num, 0);
            if (num1 < num)
                num1++;
            return num1;
        }
        public void randomShuffle()
        {
            int[] arr = new int[52];
            arr_f(arr);
            Shuffle(arr);
            show_mass(arr);
        }
        public int GetInt(string quastion)
        {
            int res;
            do
            {
                Console.Write(quastion);
            } while (!Int32.TryParse(Console.ReadLine(), out res));
            return res;
        }
        public uint GetUint(string quastion)
        {
            uint res;
            do
            {
                Console.Write(quastion);
            } while (!UInt32.TryParse(Console.ReadLine(), out res));
            return res;
        }
    }
}
