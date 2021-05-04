using System;
using System.Collections.Generic;

namespace CollectionsProject
{
    class Program
    {
        //int[] numbers = new int[10];

        List<int> TakeNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a number.Enter a negative number to exit.");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    int result = 10 / number;
                    if (number >= 0)
                        numbers.Add(number);
                }
                catch (DivideByZeroException dbz)
                {
                    Console.WriteLine("we cannot divide a number by Zero.");
                    Console.WriteLine( dbz.Message);
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("We are expecting a number .Please enter a whole number");
                    Console.WriteLine(formatException.Message);
                }
                catch (OverflowException overflowException)
                {
                    Console.WriteLine("The number is too big");
                    Console.WriteLine(overflowException.Message);
                }                
            } while (number >= 0);
            Console.WriteLine("NUmber of number entered is "+numbers.Count);
            if (numbers.Count == 0)
                numbers = null;
            return numbers;
        }
        void SortGivenNumbers()
        {
            List<int> myNumbers = TakeNumbersFromUser();
            try
            {
                if(myNumbers!= null)
                {
                    myNumbers.Sort();
                    PrintTheCollection(myNumbers);
                }
                else
                {
                    Console.WriteLine("the collection is empty");
                }
            }
            catch(NullReferenceException nrException)
            {
                Console.WriteLine("there are no numbers to be sorted");
            }
            catch(Exception e)
            {
                Console.WriteLine("Cannot sort.Sorry");
            }
        }

        private void PrintTheCollection(List<int> myNumbers)
        {
            if (myNumbers.Count > 0)
            {
                foreach (var item in myNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("nothing to print");
        }

        static void Main(string[] args)
        {
            new Program().SortGivenNumbers();
        }
    }
}
