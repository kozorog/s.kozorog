using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_n = Console.ReadLine();
            int n = Convert.ToInt32(str_n);
            int[] mass = new int[n];

            for (int i = 0; i < n; i++)

            {
                string str_t = Console.ReadLine();
                int t = Convert.ToInt32(str_t);
                mass[i] = t;
            }
            //сортировка
            Array.Sort(mass);


            for (int i = 0; i < n; i++)

            {
               string srt_t = Convert.ToString(mass)
            }

            Console.WriteLine(mass.ToString());
            //  Console.WriteLine(sum);

        }
    }
}
