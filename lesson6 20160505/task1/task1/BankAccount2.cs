using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
   public class BankAccount2: BankAccount
    {
        float Sum;
        public BankAccount2(float sum)

        {
            Sum = sum;

        }


        public float sum
        {
            get
            {
                return Sum;
            }
        }
    }
}
