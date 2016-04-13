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
            //задание 1
            Console.WriteLine("Задание 1. Ввести с консоли 2 числа. Вывести их сумму на контроль");
            string t1 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 1
            string t2 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 2
            int t11 = Convert.ToInt32(t1); //преобразуем переменную в int
            int t22 = Convert.ToInt32(t2); //преобразуем переменную в int
            int t3 = t11 + t22; // складываем
            Console.WriteLine(t3); //выводим

            //задание 2
            Console.WriteLine("Задание 1. Ввести с консоли 2 числа n и j. Вывести значение i-го бита числа n");
            string b1 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 1
            string b2 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 2
            int b11 = Convert.ToInt32(b1); //преобразуем переменную в int
            int b22 = Convert.ToInt32(b2); //преобразуем переменную в int
            int b3 = b11 + b22; // складываем
            Console.WriteLine(b3); //выводим

            //задание 2
            Console.WriteLine("Задание 1. Ввести с консоли 2 числа n и j. Вывести значение i-го бита числа n");
            string b1 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 1
            string b2 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 2
            int b11 = Convert.ToInt32(b1); //преобразуем переменную в int
            int b22 = Convert.ToInt32(b2); //преобразуем переменную в int
            int b3 = b11 + b22; // складываем
            Console.WriteLine(b3); //выводим
        }
    }
}
