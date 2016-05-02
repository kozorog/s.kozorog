using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class OooClient : Client

    {
        public string Name;
        public string BankAccount;
        //конструктор
        public OooClient(string name, string bankAccount, int id, string phone, float summa) : base(id, phone, summa)
        {
            Name = name;
            BankAccount = bankAccount;

        }

        public override string GetInfo()
        {
            return string.Format("ООО {0}. Сумма заказа: {1}.", Name, Summa);
        }

    }
}