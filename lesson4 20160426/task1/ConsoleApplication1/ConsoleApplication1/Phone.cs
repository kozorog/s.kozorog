using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Phone
    {
        private string _code;
        private string _number;
        /*
         * Создать класс “Телефон”, который содержит следующие данные: код города, 
         * номер телефона, которые не могут быть изменены. Добавить метод, 
         * который возвращает строку вида “(999) 999999” или “999999”, 
         * если код города отсутствует.

         */
        public string Write(string code, string number)

        {

            return code + number;
            //Console.WriteLine(code + number);
        }


        public Phone(string code, string number)
        {
            _code = code;
            _number = number;
        }


    }
}