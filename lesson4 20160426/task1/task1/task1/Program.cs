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
            // *Создать класс “Телефон”, который содержит следующие данные: код города,
            //*номер телефона, которые не могут быть изменены.Добавить метод,
            //*который возвращает строку вида “(999) 999999” или “999999”, 
            //*если код города отсутствует.
            

            PhoneNumber p = new PhoneNumber("", "999999");
            Console.WriteLine($"Полный номер телефона {p.GetNumber()}");


        }
    }
}
