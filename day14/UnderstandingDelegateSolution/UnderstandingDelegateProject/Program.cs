using System;

namespace UnderstandingDelegateProject
{
    class Program
    {
        void AddPassByValue(int num1)
        {
            Console.WriteLine("Pass by val before incr "+ num1);
            num1 = num1 + 1;
            Console.WriteLine("Pass by val after incr " + num1);
        }
        void AddPassByRef(ref int num1)
        {
            Console.WriteLine("Pass by ref before incr "+ num1);
            num1 = num1 + 1;
            Console.WriteLine("Pass by ref after incr "+ num1);
        }
        void CallMethods(int num1)
        {
            Console.WriteLine("Calling method- before passby ref call" + num1);
            AddPassByRef(ref num1);
            Console.WriteLine("calling method- after passby ref call" + num1);
        }

        void WorkWithNothing(SummaClass summa)
        {
            summa.PrintNothing();
            Console.WriteLine(summa.Nothing);
            summa.Nothing = 200;
        }
        void CallWork()
        {
            SummaClass summa = new SummaClass();
            summa.Nothing = 100;
            WorkWithNothing(summa);
            Console.WriteLine(summa.Nothing);
        }
        //public delegate void myDelegate();
        //void myMethod()
        //{
        //    Console.WriteLine("This is the method");
        //}
        //void YourMethod()
        //{
        //    Console.WriteLine("This is the method");
        //}
        void GetMethodsAsParameter(Action del)
        {
            del();
        }
        void CallMethodWithParamAsParameter(Action<int,int> action)
        {
            action(10, 20);
        }
        void GetMethodWithParamAndReturnAsParameter(Func<int,int> func)
        {
            int value = func(10);
            Console.WriteLine(value);
        }
        void GetMethodWithParamAndReturnBoolAsParameter(Predicate<SummaClass> func)
        {
            SummaClass summa = new SummaClass();
            summa.Nothing = 10;
            bool value = func(summa);
            Console.WriteLine("The result "+value);

        }
        void CallMethodWithMethodParameter()
        {
            //myDelegate objDelegate = new myDelegate(myMethod);
            //objDelegate += new myDelegate(YourMethod);
            //myDelegate objDelegate = delegate () { Console.WriteLine("From anon method"); };
            //objDelegate += delegate () { Console.WriteLine("From another anon method"); };
            //myDelegate objDelegate = ()=> { Console.WriteLine("From anon method"); };
            //objDelegate += ()=> { Console.WriteLine("From another anon method"); };
            //Action objDelegate = ()=> { Console.WriteLine("From anon method"); };
            //objDelegate += ()=> { Console.WriteLine("From another anon method"); };
            //Action<int, int> action = (num1, num2) => Console.WriteLine("The product is" + (num1*num2));
            //CallMethodWithParamAsParameter(action);
            //Func<int, int> myfunc = (num1) => num1 * 100;
            //GetMethodWithParamAndReturnAsParameter(myfunc);
            Predicate<SummaClass> predicate = s => s.Nothing > 10;
            GetMethodWithParamAndReturnBoolAsParameter(predicate);

        }
        static void Main(string[] args)
        {
            //new Program().CallMethods(10);
            //new Program().CallWork();
            new Program().CallMethodWithMethodParameter();
         }
    }
}
