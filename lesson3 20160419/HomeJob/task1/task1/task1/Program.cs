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
            //Считать строку с консоли. Создать словарь, где ключом будет символ строки, 
            //а значением - количество данных символов в считанной строке.
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
