using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    //сберегательный - возможность пополнения и изъятия денег со счета

    public class SberAccount: BankAccount
        
        {
      public SberAccount(int number, string owner) : base(number, owner)
        {
        }

        //private 
        public override void AddSum(decimal sumOperation)
        {
            if (IsAccountClosed)
            {
                throw new ArgumentException("Счет закрыт. Операция невозможна...");
            }
              if (sumOperation <= 0)
            {
                throw new ArgumentException("Вносимая сумма должна быть положительной и больше нуля...");
            }
            CurrentSum += sumOperation; 
                        
        }


        public override void Withdraw(decimal sumOperation)
        {
            if (sumOperation <= 0)
            {
                throw new ArgumentException("Cумма изъятия должна быть положительной и больше нуля...");
            }
            if (IsAccountClosed)
            {
                throw new ArgumentException("Счет закрыт. Операция невозможна...");
            }
            if (sumOperation > CurrentSum)
            {
                throw new ArgumentException("Cумма изъятия должна быть не больше чем остаток...");
            }
            CurrentSum -= sumOperation; 
            
        }


        public override string GetInfo()
        {
            return string.Format("Номер счета {0}. Владелец: {1}. Текущая сумма на счете: {2}. Статус счета {3}.",Number,Owner,CurrentSum, IsAccountClosed);
        }




    }
}
