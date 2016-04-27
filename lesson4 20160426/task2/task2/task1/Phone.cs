using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class PhoneNumber
    {

        private string _code;
        private string _phone;

        public string GetNumber()
        {
            if (_code == null || _code =="")
            {
                return _phone;
            }
            else
                return "("+_code+")" + _phone;
         
        } 
                
    //конструктор
    public PhoneNumber(string code, string phone)
    {
        _code = code;
        _phone = phone;
    }
        public PhoneNumber(string phone) : this (null,phone)
        {
           
        }

    }

}
