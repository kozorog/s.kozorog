using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
//Преобразовать класс “Телефон” на работу со свойствами
{
    class PhoneNumber
    {

        private string _code;
        private string _phone;

        public string GetNumber // свойство
        {
            get { return _phone;}
        }
        public string GetCode // свойство
        {
            get { return _code; }
            set
            {
                if (value == null || value == "")
                    return;
                _code = value;            }

        }
        



        //конструктор1
        public PhoneNumber(string code, string phone)
        {
            _code = code;
            _phone = phone;
        }
        //конструктор2
        public PhoneNumber(string phone) : this(null, phone)
        {

        }

    }

}
