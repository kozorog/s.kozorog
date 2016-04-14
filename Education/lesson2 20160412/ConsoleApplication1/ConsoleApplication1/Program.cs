using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_n = Console.ReadLine();
            int n = Convert.ToInt32(str_n);
            int sum=0;
            int max=0;
            for (int i=0; i < n; i++)
            
            {
               string str_t = Console.ReadLine();
                int t = Convert.ToInt32(str_t);
                sum = sum + t; //+= t
                 }


            Console.WriteLine("Сумма");
            Console.WriteLine(sum);



        }

    }
}
