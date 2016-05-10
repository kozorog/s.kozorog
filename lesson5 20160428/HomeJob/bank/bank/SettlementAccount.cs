using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    //расчетный - возможность пополнения и изъятия денег со счета, 
    //наличие платы за обслуживание, списание суммы за обслуживание со счета
        public class SettlementAccount : BankAccount

    {
        public decimal PayOfService; //оплата за обслуживание
              public SettlementAccount(int number, string owner, decimal payOfService) : base(number, owner)
        {
            PayOfService = payOfService;

        }

        public void PayOfServiceSum()
        {

            CurrentSum -= PayOfService;

        }

        public override void AddAsset(decimal sumOperation)
        {
            if (IsAccountClosed)
            {
                throw new Exception("Счет закрыт. Операция невозможна...");
            }
            if (sumOperation <= 0)
            {
                throw new ArgumentException("Вносимая сумма должна быть больше нуля...");
            }
            CurrentSum += sumOperation;

        }


        public override void Withdraw(decimal sumOperation)
        {
            if (sumOperation <= 0)
            {
                throw new ArgumentException("Cумма изъятия должна быть больше нуля...");
            }
            if (IsAccountClosed)
            {
                throw new Exception("Счет закрыт. Операция невозможна...");
            }
            if (sumOperation > CurrentSum)
            {
                throw new ArgumentException("Cумма изъятия должна быть не больше чем остаток...");
            }
            CurrentSum -= sumOperation;

        }



        public override string GetInfo()
        {
            return string.Format("Номер счета {0}. Владелец: {1}. Текущая сумма на счете: {2}. Списано за обслуживание: {3}. Статус счета {4}.",
                Number, Owner, CurrentSum, PayOfService, IsAccountClosed);
        }




    }


}
