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
            // для сбер. счета
            SberAccount sberAccount = new SberAccount(1, "Вася");
            sberAccount.AddAsset(1000);
            sberAccount.Withdraw(200); //изъятие
            sberAccount.СloseAccount();
            Console.WriteLine(sberAccount.GetInfo()); //вывод инфы на экран
            */
            

            //для накопительного счета
            /*
            SavingsAccount savingAccount = new SavingsAccount(2, "Петя");
            savingAccount.AddAsset(1000); //добавление 
            savingAccount.CapitalisationSum(10); // капитализация по вкладу от процента
            //savingAccount.Withdraw(100); //списание
            savingAccount.СloseAccount();
            Console.WriteLine(savingAccount.GetInfo()); //вывод инфы на экран
            */

            //для рассчетного счета
            /*
            SettlementAccount settlementAccount = new SettlementAccount(3, "Вова Путин");
            settlementAccount.AddAsset(1000);
            settlementAccount.Withdraw(500);
            settlementAccount.PayOfServiceSum(100);
            //settlementAccount.СloseAccount();
            Console.WriteLine(settlementAccount.GetInfo()); //вывод инфы на экран
            */
            
            //для металлического счета
            /*
            MetallAccounts metallAccounts = new MetallAccounts(4, "Дима", Metalls.Palladium); //Gold, Silver, Platinum, Palladium
            metallAccounts.AddAsset(500);
            metallAccounts.Withdraw(400);
            Console.WriteLine(metallAccounts.GetInfo()); //вывод инфы на экран
            */

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
