using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Computer: Calculator  //derived class
    {
        public Computer()
        {
            Make = "IBM";
            Speed = 10001;
        }
        //public void DoWork()
        //{
        //    Console.WriteLine("Done work");
        //}
        public override void Dowork()
        {
            base.Dowork();
            Console.WriteLine("Does work");
        }
    }

    class Calculator //base class
    {
        public string Make { get; set; }
        public int Speed { get; set; }
        public Calculator()
        {
            Make = "ABC Corp.";
            Speed = 101;
        }
        //public void Calculate()
        //{
        //    Console.WriteLine("Calculating...");
        //}
        public virtual void Dowork()
        {
            Console.WriteLine("Calculating....");
        }

        public void PrintCalculatorInfo()
        {
            Console.WriteLine("Make " + Make);
            Console.WriteLine("Speed" + Speed);
        }
    }
}
