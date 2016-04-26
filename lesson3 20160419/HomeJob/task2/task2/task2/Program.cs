using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Считывать с консоли числа, пока не будет введено число “-1”, среди введенных чисел вывести все дублирующиеся.

            Console.WriteLine("Введите строку с консоли");
            string valueString = Console.ReadLine();
            char[] ar = valueString.ToCharArray();
            int LengthString = ar.Length;

            Console.WriteLine("Вы ввели: {0} Длинной:{1}", valueString, LengthString);

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var i in ar)
            {

                {
                    if (!dict.ContainsKey(i))
                    {
                        dict.Add(i, valueString.Count(x => x == i));
                    }
                }


            }

            //вывод словаря на экран

            foreach (KeyValuePair<char, int> pair in dict)
            {
                Console.WriteLine("Key: {0}  Value {1}", pair.Key, pair.Value);
            }

        }
    }
}
