using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class SettlementAccount
    {
        int NumberAccount;
        string OwnerAccount;
        float CurrentSum;
        float PercentOfDeposit;
        float SumOperation;

         
        
        //создаем конструктор
        public SettlementAccount(int numberAccount, string ownerAccount, float currentSum, float percentOfDeposit, float sumOperation)
            {
            NumberAccount = numberAccount;
            OwnerAccount = ownerAccount;
            CurrentSum = currentSum;
            PercentOfDeposit = percentOfDeposit;
            SumOperation = sumOperation;

            }

        public void AddSum(float sumOperation) //добавление счета
        {
            CurrentSum += SumOperation;
            

        }


        public void WithdrawalSum(float sumOperation) //изъятие со счета
        {
            if (sumOperation > CurrentSum)
            {
                return;
            }

            CurrentSum -= SumOperation;


        }
        public void closedAccount(bool closed) //закрытие счета
        {

        }

    }
}
