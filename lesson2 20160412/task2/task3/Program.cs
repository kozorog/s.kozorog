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

            //Заполнить с консоли массив из N элементов. Отсортировать. Вывести результат. N - задается с консоли
            Console.WriteLine("Введите размер массива N ");
            string str_n = Console.ReadLine();
            int n = Convert.ToInt32(str_n);
            int[] mass = new int[n];

            for (int i = 0; i < n; i++)

            {
                Console.WriteLine("Введите число " + i + " элемента массива");
                string str_t = Console.ReadLine();
                int t = Convert.ToInt32(str_t);
                mass[i] = t;
            }
            //сортировка
            Array.Sort(mass);


            for (int i = 0; i < n; i++)

            {
                Console.WriteLine(mass[i]);
            }
                        
            

        }
    }
}
