using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    //обезличенный металлический счет - тип металла, количество грамм, стоимость за грамм(текущий курс), 
    //возможность пополнять и обналичивать счет по текущему курсу


    public class MetallAccounts : BankAccount
    {

        public decimal WeightMetall; // вес металла
        public string TypeMetall;

        public MetallAccounts(int number, string owner, decimal weightMetall, string typeMetall) : base(number, owner)
        {
            WeightMetall = weightMetall;
            TypeMetall = typeMetall;
        }

        public override void AddSum(decimal weightMetall)
        {
            if (IsAccountClosed)
            {
                throw new Exception("Счет закрыт. Операция невозможна...");
            }
            if (weightMetall <= 0)
            {
                throw new ArgumentException("Масса вносимого металла должна быть больше нуля...");
            }

            CurrentSum += weightMetall*(MetallPriceList.GetValue(Metalls.Gold));
            //Console.WriteLine(MetallPriceList.GetValue(Metalls.Gold));

        }


        public override void Withdraw(decimal weightMetall)
        {
            if (weightMetall <= 0)
            {
                throw new ArgumentException("Масса металла должна быть больше нуля...");
            }
            if (IsAccountClosed)
            {
                throw new Exception("Счет закрыт. Операция невозможна...");
            }
            if (weightMetall*(MetallPriceList.GetValue(Metalls.Gold)) > CurrentSum)
            {
                throw new ArgumentException("Масса изымаемого металла в пересчете на сумму должна быть не больше чем остаток...");
            }
            CurrentSum -= weightMetall * (MetallPriceList.GetValue(Metalls.Gold));

        }



        public override string GetInfo()
        {
            return string.Format("Номер счета {0}. Тип металла {1}. Текущая сумма на счете: {2}. Статус счета {3}.",
                Number, Metalls.Gold, CurrentSum, IsAccountClosed);
        }




    }

}
