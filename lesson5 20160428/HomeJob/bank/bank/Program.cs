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
            SberAccount sberAccount = new SberAccount(1,"Вася");
            sberAccount.AddSum(100); //добавление 
            sberAccount.Withdraw(99); //изъятие
            sberAccount.Withdraw(1); // еще изъятие
            sberAccount.СloseAccount();
            Console.WriteLine(sberAccount.GetInfo()); //вывод инфы на экран
            



        }
    }
}
    