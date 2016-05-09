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
        public abstract void AddSum(decimal sumOperation); //пополнение счета  сбер накоп расчетный


        //метод изъятия денег

        public abstract void Withdraw(decimal sumOperation); //изъятие со счета


        //Реализовать метод закрытия счета. С закрытым счетом нельзя проводить никакие операции. 
        //Счет не может быть закрыт, если он имеет положительный баланс.



        public void СloseAccount()
        {
            if (IsAccountClosed)
            {
                throw new Exception("Операции с закрытым счетом невозможны...");
            }
            if (CurrentSum > 0)
            {

                throw new Exception("Невозможно закрыть счет, т.к на нем больше нуля денег...");
            }

            IsAccountClosed = true;




        }
        public virtual string GetInfo()
        {
            return "";
        }



    }



}
