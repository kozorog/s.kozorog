using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class BankAccounts
    {
        int NumberAccount;
        string OwnerAccount;
        float CurrentSumm;
        //создаем конструктор
        public BankAccounts (int numberAccount, string ownerAccount, float currentSumm)
            {
            NumberAccount = numberAccount;
            OwnerAccount = ownerAccount;
            CurrentSumm = currentSumm;

            }
    }
}
