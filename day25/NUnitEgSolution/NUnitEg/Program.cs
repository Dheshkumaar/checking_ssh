using System;

namespace NUnitEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Banking obj = new Banking();
            obj.DepositAmount(500);
            Console.WriteLine("Balance:"+obj.Balance);
            string WithDraw = obj.WithdrawAmount(600);
            Console.WriteLine("Balance:"+obj.Balance);
            Console.WriteLine(WithDraw);
        }
    }
}
