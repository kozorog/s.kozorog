using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public abstract class BankAccount
    {
        protected int Number;
        protected string Owner;
        protected Decimal CurrentSum;
        protected bool IsAccountClosed;
        public BankAccount(int number, string owner)
        {
            Number = number;
            Owner = owner;
            CurrentSum = 0;
            IsAccountClosed = false;
        }
        //метод добавления денег на счет
        public virtual void AddAsset(decimal sumOperation) //пополнение счета  сбер накоп расчетный

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


        public virtual void Withdraw(decimal sumOperation)
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


        public void СloseAccount()
        {
            if (IsAccountClosed)
            {
                throw new Exception("Операции с закрытым счетом невозможны...");
            }
            if (CurrentSum > 0)
            {
                throw new Exception("Невозможно закрыть счет, т.к на нем есть деньги...");
            }
            IsAccountClosed = true;
        }
        public virtual string GetInfo()
        {
            return "";
        }
    }
}
