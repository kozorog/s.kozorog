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

            //--------------
            float num;
            List<float> numbers = new List<float>();
            bool flag = true;
            while (flag)

            {

                Console.WriteLine("Введите число:");
                string x1 = Console.ReadLine();

                if (!float.TryParse(x1, out num)) //проверка введенных символово на вшивость
                {
                    Console.WriteLine("Введен символ вместо числа, повторите попытку");
                }
                else
                {

                    if (num == -1) //проверка на  -1
                    {
                        flag = false;
                    }
                    else
                    {
                        numbers.Add(num);
                    }
                }

            }

            Dictionary<float, int> dic = new Dictionary<float, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (dic.ContainsKey(numbers[i]))
                {
                    dic[numbers[i]] = ++dic[numbers[i]];
                }
                else
                    dic.Add(numbers[i], 1);
            }

            //вывод списка на экран
            Console.WriteLine("Полученный на входе лист:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Key: {0}", numbers[i]);
            }


            //вывод списка на экран

            Console.WriteLine("Cписок дублей :");
            foreach (KeyValuePair<float, int> kvp in dic)

                if (kvp.Value > 1)
                {
                    Console.WriteLine("Номер {0} имеет {1} повторений (в т.ч. дублей)", kvp.Key, kvp.Value);
                }
            //  else
            // {
            //   Console.WriteLine("Нет дублей");
            // }




        }
    }
}