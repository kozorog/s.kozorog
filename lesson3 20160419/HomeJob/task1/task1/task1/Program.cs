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
            int lengthString = ar.Length;
            Console.WriteLine("Вы ввели строку:{0} длинной: {1} ", valueString, lengthString);
            Dictionary<char, int> resultDictionary = new Dictionary<char, int>();

            //Реализовать без методов-расширений типа Count
            /*
            foreach (var i in ar)
            {
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, valueString.Count(x => x == i));
                }
            }
            */

            //Надо реализовать без методов-расширений типа Count
            //Реализовал :-)

            for (int i = 0; i < lengthString; i++)
                if (!resultDictionary.ContainsKey(valueString[i]))
                {
                    int count = 0;
                    for (int j = i; j < lengthString; j++)
                    {
                        if (valueString[i] == valueString[j]) count++;
                    }
                    resultDictionary.Add(valueString[i], count);
                }

            //вывод словаря на экран
            Console.WriteLine("Полученный словарь:");
            foreach (KeyValuePair<char, int> pair in resultDictionary)
            {
                Console.WriteLine("Key: {0}  Value {1}", pair.Key, pair.Value);
            }
        }
    }
}
