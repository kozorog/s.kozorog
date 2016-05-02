using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Client
    {
        public int Id;
        public string Phone;
        public float Summa;

        //конструктор
        public Client(int id, string phone, float summa)
        {
            Id = id;
            Phone = phone;
            Summa = summa;
        }


        public virtual string GetInfo()
        {
            return "";
        }

    }
}

