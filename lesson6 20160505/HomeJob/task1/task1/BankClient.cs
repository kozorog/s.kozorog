using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public abstract class BankClient
    {
        public int Account;
        public decimal Summ;
        public bool IsAccountClosed;

        public BankClient(int account, decimal summ)
        {
            Account = account;
            Summ = summ;
            IsAccountClosed = false;
         }
        //метод добавления денег на счет
        public abstract void AddAsset(decimal sumOperation); //пополнение счета  сбер накоп расчетный


        //метод изъятия денег

        public abstract void Withdraw(decimal sumOperation); //изъятие со счета

    }
}
