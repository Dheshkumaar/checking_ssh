using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitEg
{
    public class Banking
    {
        public double Balance { get; set; }
        public string msg { get; set; }
        public Banking()
        {
            Balance = 0;
        }
        public void DepositAmount(int amt)
        {
            if (amt < 0)
                Balance = Balance;
            else
                Balance += amt;
        }

        public string WithdrawAmount(int amt)
        {
            if(Balance> amt)
            {
                Balance -= amt;
                msg = "Success";
                return msg;
            }
            else
            {
                msg = "Sorry! Not Enough Balance ";
                return msg;
            }

        }
    }
}
