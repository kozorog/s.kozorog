using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class IpClient : Client
    {
        public string Fio;
        public DateTime Birth;

        //конструктор
        public IpClient(string fio, DateTime birth, int id, string phone, float summa) : base(id, phone, summa)
        {
            Fio = fio;
            Birth = birth;
        }

        public override string GetInfo()
        {
            return string.Format("ИП {0}. Сумма заказа: {1}.", Fio, Summa);
        }

    }
}
