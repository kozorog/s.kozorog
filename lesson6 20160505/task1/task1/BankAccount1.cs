using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class BankAccount1 : BankAccount
    {
        float Sum;
        public BankAccount1(float sum)

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