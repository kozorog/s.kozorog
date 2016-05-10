using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    //накопительный - возможность пополнения и изъятия денег со счета, но не меньше первоначального взноса, 
    //наличие процентной ставки, капитализация процентов за месяц


    public class SavingsAccount : BankAccount

    {
        public decimal PercentOfDeposit; //годовая процентная ставка 
        public decimal Capitalisation; // должна быть за месяц
        public SavingsAccount(int number, string owner, decimal percentOfDeposit) : base(number, owner)
        {
            PercentOfDeposit = percentOfDeposit;

        }

        public void CapitalisationSum()
        {

            Capitalisation = CurrentSum * PercentOfDeposit / (100 * 12); //проценты за месяц
            CurrentSum += Capitalisation;


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
            return string.Format("Номер счета {0}. Владелец: {1}. Текущая сумма на счете: {2}. Проценты за месяц: {3}. Статус счета {4}.",
                Number, Owner, CurrentSum, Capitalisation, IsAccountClosed);
        }




    }
}
