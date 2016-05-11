using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    //сберегательный - возможность пополнения и изъятия денег со счета
    public class SberAccount : BankAccount
    {
        public SberAccount(int number, string owner) : base(number, owner)
        {
        }
        
        public override string GetInfo()
        {
            return string.Format("Номер счета {0}. Владелец: {1}. Текущая сумма на счете: {2}. Статус счета {3}.", Number, Owner, CurrentSum, IsAccountClosed);
        }
    }
}
