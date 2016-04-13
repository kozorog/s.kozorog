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
            Console.WriteLine("Задание 1. Ввести с консоли 2 числа. Вывести их сумму на конcоль");
            Console.WriteLine("Введите первое число");
            string number1 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 1
            Console.WriteLine("Введите второе число");
            string number2 = Console.ReadLine(); //объявляем и считываем с консоли  переменную 2
            int num1 = Convert.ToInt32(number1); //преобразуем переменную в int
            int num2 = Convert.ToInt32(number2); //преобразуем переменную в int
            int sum = num1+num2; // складываем
            Console.WriteLine("Суммируем. Получили:");
            Console.WriteLine(sum); //выводим
            Console.ReadLine(); //типо пауза

            //задание 2
            Console.WriteLine("Задание 2");
            Console.WriteLine( "Ввести с консоли 2 числа n и i. Вывести значение i-го бита числа n");

            string str_n = Console.ReadLine(); //объявляем и считываем с консоли  переменную 1
            string str_i = Console.ReadLine(); //объявляем и считываем с консоли  переменную 2

            int n = Convert.ToInt32(str_n); //преобразуем переменную в int
            int i = Convert.ToInt32(str_i); //преобразуем переменную в int
            n = n >> i; //сдвигаем;
            n = n & 1; //
            Console.WriteLine("Ответ:");
            Console.WriteLine(n); //выводим 
                         
            Console.ReadLine(); //типо пауза


            //задание 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Ввести с консоли число. Обнулить последний бит этого числа. Вывести на консоль");

          // не сделал. может завтра
            

            //int m = Convert.ToInt32(i); //преобразуем переменную в int
            
            //m = a >> aa; //сдвигаем;
            //int ccc = a & 1; //
            //Console.WriteLine(a); //выводим



        }
    }
}
