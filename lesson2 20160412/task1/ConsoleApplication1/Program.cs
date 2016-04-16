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
            //Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения, количество четных чисел, произведение нечетных чисел.
            //
            //
            Console.WriteLine("Введите количество чисел ");
            string str_n = Console.ReadLine();
            int n = Convert.ToInt32(str_n);
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите число: " + (i + 1));
                mass[i] = Convert.ToInt32(Console.ReadLine());

            }

            //Console.WriteLine("Сумма этих чисел равна: ");
            int sum = mass.Sum();
            Console.WriteLine("Сумма этих чисел: " + sum);

            //вывод максимального числа
            int Max = mass.Max();
            Console.WriteLine("Максимальное число: " + Max);


            //вывод минимального числа
            int Min = mass.Min();
            Console.WriteLine("Минимальное число: " + Min);

            //вывод количества четных чисел
            int countEven=0;
            int multOddEven = 1;
            foreach (int ii in mass)
            {
                if ((ii % 2 == 0)) countEven++;
                else
                    
                    multOddEven *= ii;  // произведение нечетных чисел
            }
            Console.WriteLine("Количество четных чисел: " + countEven);
                              
          
            Console.WriteLine("Произведение нечетных чисел: " + multOddEven);
                   
         
        }

    }
}
