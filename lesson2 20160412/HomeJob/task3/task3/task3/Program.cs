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

            //Калькулятор.С консоли вводится левый операнд, операция, правый операнд. 
            //Выводится результат операции над операндами.
            //Реализовать как минимум 4 операции, обработку ошибок (деление на 0 и др).

            Console.ForegroundColor = ConsoleColor.Green;
            char continueFlag = 'y';
            while (continueFlag == 'y')
            {


                char Operation = '\0';

                float Operand1;
                float Operand2;
                Console.WriteLine("Если не хотите считать в уме, тогда введте первое число:)");
                string x1 = Console.ReadLine();

                if (!float.TryParse(x1, out Operand1))
                {
                    Console.WriteLine("Введен символ вместо первого числа");
                    goto Stop_Err;
                }
                //----------------ввод втрого числа
                Console.WriteLine("Введите второе число:)");
                string x2 = Console.ReadLine();
                if (!float.TryParse(x2, out Operand2))
                {
                    Console.WriteLine("Введен символ вместо второго числа");
                    goto Stop_Err;
                }

                Console.WriteLine("Введите символ операции: + сложить; - вычесть; * умножить; / разделить)");
                Operation = char.Parse(Console.ReadLine());


                switch (Operation)
                {
                    case '+': Console.WriteLine("Сумма чисел составляет: " + (Operand1 + Operand2)); break;
                    case '-': Console.WriteLine("Разность чисел состовляет: " + (Operand1 - Operand2)); break;
                    case '*': Console.WriteLine("Произведение чисел составляет: " + (Operand1 * Operand2)); break;
                    case '/':
                        if (Operand2 != 0)

                            Console.WriteLine("Отношение чисел составляет: " + (Operand1 / Operand2));

                        else
                        {
                            Console.WriteLine("На ноль делить нельзя, повторите попытку: ");
                        }
                        break;


                    default:
                        {

                            Console.WriteLine("введенная операция некорректна, попробуйте еще раз ");

                        }
                        break;
                }

                Stop_Err:
                Console.WriteLine("Хотите продолжить y/n?");
                continueFlag = Convert.ToChar(Console.ReadLine());
            }

        }

    }
}
