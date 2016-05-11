using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    //расчетный - возможность пополнения и изъятия денег со счета, наличие платы за обслуживание, списание суммы за обслуживание со счета
    public class SettlementAccount : BankAccount
    {
        public decimal PayOfService;
        public SettlementAccount(int number, string owner) : base(number, owner)
        {
        }
        public void PayOfServiceSum(decimal payOfService)
        {

            if (payOfService > CurrentSum)
            {
                throw new Exception("Плата за обслуживание не произведена. На счете недостаточно средств...");
            }
            CurrentSum -= payOfService;
            PayOfService = payOfService;
        }

        public override string GetInfo()
        {
            return string.Format("Номер счета {0}. Владелец: {1}.  Текущая сумма на счете: {2}. Снято за обслуживание {3}. Статус счета {4}.", Number, Owner, CurrentSum, PayOfService, IsAccountClosed);
        }
    }
}
