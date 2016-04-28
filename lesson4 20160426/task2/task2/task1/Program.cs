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
            //Преобразовать класс “Телефон” на работу со свойствами



            PhoneNumber p = new PhoneNumber("999", "999999");
            Console.WriteLine($"Полный номер телефона {p.GetCode} {p.GetNumber}  ");


        }
    }
}
