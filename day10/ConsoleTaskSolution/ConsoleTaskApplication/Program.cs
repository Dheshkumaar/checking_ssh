using System;

namespace ConsoleTaskApplication
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Enter a number");
            int num1 = Int32.Parse(Console.ReadLine());
            if(num1 % 2 == 0)
                Console.WriteLine("{0} is even number",num1);
            else
                Console.WriteLine("{0} is not a even number",num1);
        } 

        static void Task2()
        {
            int sum = 0;
            Console.WriteLine("Enter input");
            int num1 = Int32.Parse(Console.ReadLine());
            while(num1 >= 0)
            {
                if (num1 % 7 == 0)
                    sum += num1;
                Console.WriteLine("enter Input:");
                num1 = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("the result is" +sum);

        }
        static void Task3()
        {
            Console.WriteLine("minimum number(starting range): ");
            int starting_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maximum number(ending range):");
            int ending_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The prime numbers between {0} and {1} are : \n", starting_no, ending_no);
            for(int i = starting_no; i <= ending_no; i++)
            {
                int flag = 0;
                for(int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine(i);
            }
        }

        static void Task4()
        {
            int count = 0;
            do
            {
                Console.WriteLine("Username: ");
                string user = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (user == "Ramu" & password == "1234")
                {
                    Console.WriteLine("Yes! Welcome");
                    break;
                }

                else
                { 
                    Console.WriteLine("Try Again");
                    count = count + 1;
                }
            } while (count < 3);
            if(count >= 3)
            {
                Console.WriteLine("Account is blocked");
            }
                            
        }

        static void Task5()
        {
            Console.WriteLine("NUMBER 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NUMBER 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operation:");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Result ---> Add: "+(number1+number2));
                    break;
                case "-":
                    Console.WriteLine("Result ---> SUB: " + (number1 - number2));
                    break;
                case "*":
                    Console.WriteLine("Result ---> MUL: " + (number1 * number2));
                    break;
                case "/":
                    Console.WriteLine("Result ---> Div: " + (number1 / number2));
                    break;
                default:
                    Console.WriteLine(" Invalid");
                    break;
            }
        } 
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
        }
    }
}
