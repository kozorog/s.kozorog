using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    //накопительный - возможность пополнения и изъятия денег со счета, но не меньше первоначального взноса, наличие процентной ставки, капитализация процентов за месяц
    public class SavingsAccount : BankAccount
    {
        public decimal PercentOfDeposit; //годовая процентная ставка 
        public decimal Capitalisation; // должна быть за месяц
        public SavingsAccount(int number, string owner) : base(number, owner)
        {

        }

        public void CapitalisationSum(decimal percentOfDeposit)
        {
            Capitalisation = CurrentSum * percentOfDeposit / (100 * 12); //проценты за месяц
            CurrentSum += Capitalisation;
            PercentOfDeposit = percentOfDeposit;
        }

        
        public override string GetInfo()
        {
            return string.Format("Номер счета {0}. Владелец: {1}. Текущая сумма на счете: {2}. Ставка по вкладу {3}. Проценты за месяц: {4}. Статус счета {5}.", Number, Owner, CurrentSum, PercentOfDeposit, Capitalisation, IsAccountClosed);
        }
    }
}
