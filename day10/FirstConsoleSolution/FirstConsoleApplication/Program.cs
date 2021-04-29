using System;

namespace FirstConsoleApplication
{
    class Program
    {
        static int num1, num2;

        static void TakeInput()
        {
            Console.WriteLine("Please enter the first integer");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Second integer");
            num2 = Int32.Parse(Console.ReadLine());
        }
        static void FirstMethod()
        {
            //Console.WriteLine("Hello From My Method");
            Console.WriteLine("User enter the data:");
            string data = Console.ReadLine();
            Console.WriteLine("User user u enterd " + data);
        }
        static void DealingNUmbers()
        {
            Console.WriteLine("Enter a integer:");
            //string number = Console.ReadLine();
            //int num = Convert.ToInt32(number);
            int num = Convert.ToInt32(Console.ReadLine());
            num *= 100;
            Console.WriteLine("the number multiplied by 100 is" + num);
        }
        static void Calc()
        {
            Console.WriteLine("Enter two numbers");
            float num1 = Convert.ToSingle(Console.ReadLine());
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Add: " + (num1 + num2) + " sub: " + (num1 - num2) + "MUL: " + (num1 * num2) + "Div: " + (num1 / num2));
        }
        static void Calculate()
        {
            TakeInput();
            int sum = num1 + num2;
            float fNum1, fNum2;
            fNum1 = num1;
            fNum2 = num2;
            float result = (fNum1 / fNum2);
            Console.WriteLine("the div of {0} and{1} = {2}", num1, num2, result);
        }
        static void Check()
        {
            TakeInput();
            if (num1 == num2)
                Console.WriteLine("Both are equal");
            else if (num1 > num2)
                Console.WriteLine("num {0} is greater than {1}", num1, num2);
            else
                Console.WriteLine("num {1} is greater than {0}", num1, num2);
        }
        static void PrintDayOfWeek()
        {
            Console.WriteLine("Please enter a day");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine("Weekday");
                    break;
                case "Friday":
                    Console.WriteLine("Weekday but will be soon");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }
        }
        static void UnderstandingIteration()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("For Loop end");
            //int flag = 0, sum = 0;
            //while (flag >= 0)
            //{
            //    sum += flag;
            //    Console.WriteLine("please enter a number");
            //    flag = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("here we go... The sum is "+sum);
            int flag = -1, sum = 0;
            do
            {
                Console.WriteLine("Please enter a number");
                flag = Convert.ToInt32(Console.ReadLine());
                sum += flag;
            } while (flag >= 0);
            Console.WriteLine("here we go... The sum is " + sum);
        }

        static void UnderstandingErrorHandling()
        {
            int num = 0;
            Console.WriteLine("Please  enter the number");
            //num = Int32.Parse(Console.ReadLine());
            //bool check = Int32.TryParse(Console.ReadLine(),out num);
            while (Int32.TryParse(Console.ReadLine(), out num) == false)
                Console.WriteLine("Invalid input,.Please enter a number.");
            Console.WriteLine("the number is" + num);

        }
        static void Main(string[] args)
        {
            //FirstMethod();
            //DealingNUmbers();
            //Calculate();
            //Check();
            //PrintDayOfWeek();
            //UnderstandingIteration();
            UnderstandingErrorHandling();
            //Console.WriteLine("Hello World!");
        }
    }
}

