using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Заполнить массив длиной N случайными числами. Ввести с консоли число A. Вывести Yes, если число A есть в массиве, No - в противном случае.

            Console.WriteLine("Введите длину массива");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число А");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("А = " + A);

            Random rand = new Random();
            Int32[] mass = new Int32[N];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(10); //ограничился 100000 
            }

            //Вывод на консоль
            Console.WriteLine("Массив");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }




            foreach (int ii in mass)
            {
                if (ii  == A)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }



        }
    }
}

