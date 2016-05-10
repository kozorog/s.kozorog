using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //для сбер. счета
            SberAccount sberAccount = new SberAccount(1,"Вася");
            sberAccount.AddAsset(100); //добавление 
            sberAccount.Withdraw(99); //изъятие
            sberAccount.Withdraw(1); // еще изъятие
            sberAccount.СloseAccount();
            Console.WriteLine(sberAccount.GetInfo()); //вывод инфы на экран
            */

            //для накопительного счета
            /*
            SavingsAccount savingAccount = new SavingsAccount(2, "Петя", 11);
            savingAccount.AddAsset(5000); //добавление 
            savingAccount.CapitalisationSum(); // капитализация
            savingAccount.Withdraw(10000);
            //savingAccount.СloseAccount();
            Console.WriteLine(savingAccount.GetInfo()); //вывод инфы на экран
            */

            //для рассчетного счета
            /*
            SettlementAccount settlementAccount = new SettlementAccount(3, "Вова Путин", 50);
            settlementAccount.AddAsset(1000);
            settlementAccount.PayOfServiceSum();
            settlementAccount.Withdraw(10);
            Console.WriteLine(settlementAccount.GetInfo()); //вывод инфы на экран
            */
            //для металлического счета
             
            MetallAccounts metallAccounts = new MetallAccounts(4, "Дима", Metalls.Palladium); //Gold, Silver, Platinum, Palladium
            metallAccounts.AddAsset(500);
          //  metallAccounts.Withdraw(600);
            Console.WriteLine(metallAccounts.GetInfo()); //вывод инфы на экран
            

        }
    }

    public enum Metalls
    {
        Gold,
        Silver,
        Platinum,
        Palladium
    }
}
    