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
            /*Сделать методы для считывания целых чисел, дробных чисел.
                       Сделать методы для вывода на консоль этих типов данных, 
                       массивов целых и дробных чисел.*/
            Console.WriteLine("Введите 3 целых числа. Некорректный введеный символ будет приравнен 0");
            int x1 = GetInt();
            int x2 = GetInt();
            int x3 = GetInt();
            Console.WriteLine("Введите 3 дробных числа. Некорректный введеный символ будет приравнен 0");
            float y1 = GetFloat();
            float y2 = GetFloat();
            float y3 = GetFloat();
            //вывод данных на консоль через методы
            PrintInt(x1, x2, x3);
            PrintFloat(y1, y2, y3);

        }

        //метод считывания целых чисел
        private static int GetInt()
        {
            int value;

            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            return 0;
        }
        //метод считывания дробных чисел
        private static float GetFloat()
        {
            float value;

            if (float.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            return 0;
        }

        //метод вывода на консоль данных 
        private static void PrintInt(int value1, int value2, int value3)
        {
            Console.WriteLine($"x1 = {value1}; x2 = {value2}; x3={value3};");
        }
        private static void PrintFloat(float value1, float value2, float value3)
        {
            Console.WriteLine($"y1 = {value1}; y2 = {value2}; y3 = {value3};");
        }


    }
}


