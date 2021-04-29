using System;

namespace UnderstandingOOProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phone phone = new Phone();
            //phone.CheckWorkPublic();
            //phone.CheckWorkInternal();
            //phone.CheckWorkPrivate();
            //phone.CheckWorkProtected();
            //Computer computer = new Computer();
            //computer.PrintCalculatorInfo();
            //computer.Calculate();
            //computer.DoWork();
            //Calculator calculator1, calculator2;
            //calculator1 = new Calculator();
            //calculator1.Make = "AAA Corp";
            //Console.WriteLine("Calculator1 ref");
            //calculator1.PrintCalculatorInfo();
            //calculator2 = calculator1;
            //calculator2.Make = "BBB COrp";
            //Console.WriteLine("Calculator 1 ref");
            //calculator1.PrintCalculatorInfo();
            //Console.WriteLine("Calculator 2 ref");
            //calculator2.PrintCalculatorInfo();
            Calculator calculator = new Computer();
            calculator.PrintCalculatorInfo();
            calculator.Dowork();
            Console.ReadKey();
        }
    }
}
