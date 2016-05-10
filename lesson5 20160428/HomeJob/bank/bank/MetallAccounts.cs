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
        //public string TypeMetall;
        Metalls metallType;

        public MetallAccounts(int number, string owner, Metalls typeMetall) : base(number, owner)
        {
            metallType = typeMetall;
        }

        public override void AddAsset(decimal weightMetall)
        {
            if (IsAccountClosed)
            {
                throw new Exception("Счет закрыт. Операция невозможна...");
            }
            if (weightMetall <= 0)
            {
                throw new ArgumentException("Масса вносимого металла должна быть больше нуля...");
            }

            CurrentSum += weightMetall*(MetallPriceList.GetValue(metallType));
            

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
            CurrentSum -= weightMetall * (MetallPriceList.GetValue(metallType));

        }



        public override string GetInfo()
        {
            return string.Format("Номер счета {0}. Тип металла {1}. Курс металла {2}. Текущая сумма на счете: {3}. Статус счета {4}.",
                Number, metallType, MetallPriceList.GetValue(metallType), CurrentSum, IsAccountClosed);
        }




    }

}
