using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class BankAccount//SettlementAccount
    {
        int NumberAccount;
        string OwnerAccount;
        float CurrentSum;
       
       // float SumOperation;
        bool StatusAccount;

         
        
        //создаем конструктор
        public SettlementAccount(int numberAccount, string ownerAccount, float currentSum, float percentOfDeposit, float sumOperation, bool statusAccount)
            {
            NumberAccount = numberAccount;
            OwnerAccount = ownerAccount;
            CurrentSum = currentSum;
         //   PercentOfDeposit = percentOfDeposit;
          //  SumOperation = sumOperation;
          //  StatusAccount = statusAccount;


            }

        public void AddSum(float sumOperation) //пополнение счета  сбер накоп расчетный
        {
            CurrentSum += SumOperation;
            

        }


        public void Withdraw(float sumOperation) //изъятие со счета
        {
            if (sumOperation > CurrentSum)
            {
                //return;
                Console.WriteLine("Недостаточно денег на счете");
            }

            CurrentSum -= SumOperation;


        }

        //Реализовать метод закрытия счета. С закрытым счетом нельзя проводить никакие операции. 
        //Счет не может быть закрыт, если он имеет положительный баланс.

        public void СlosedAccount(bool statusAccount) //закрытие счета True = закрыт: False = открыт
        {
            if (CurrentSum > 0)
            {
                Console.WriteLine("Счет не может быть закрыт, т.к. он имеет положительный баланс");
            }
            StatusAccount = false;

        }

    }
}
