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
            if(Card_number.Length == 16) { 
                Card_number = reverse(Card_number);
                string sum = Sumandmul(Card_number);
                Console.WriteLine(sum);
            }
            else
                Console.WriteLine("Enter size of card is 16");
        }

        private string reverse(string number)
        {
            string output = string.Empty;
            char[] chars = number.ToCharArray();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                output += chars[i];
            }
            return output; 
        }
        private string Sumandmul(string number)
        {
            return n;
        }

        static void Main(string[] args)
        {
            new Program().TakeUserData();
        }
    }
}
