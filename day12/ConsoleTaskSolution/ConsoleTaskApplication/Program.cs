using System;

namespace ConsoleTaskApplication
{
    class Program
    {
        public string Card_number { get; set; }
        public string Date { get; set; } 
        public int CVV { get; set; }

        public void TakeUserData()
        {
            Console.WriteLine("Please enter the Card Number");
            Card_number = Console.ReadLine();
            if(Card_number.Length == 16)
                reverse();
            else
                Console.WriteLine("Enter size of card is 16");

        }

        private void reverse()
        {
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
