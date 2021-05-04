using System;

namespace ConsoleTaskApplication
{
    class Program
    {
        public string Card_number { get; set; }
        public string CVV { get; set; }

        public void TakeUserData()
        {
            Console.WriteLine("Please enter the Card Number");
            Card_number = Console.ReadLine();
            Console.WriteLine("Enter the Year on the card");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Month on the card");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Day on the card");
            int Day = Convert.ToInt32(Console.ReadLine());
            DateTime date = new DateTime(Year, Month, Day);
            Console.WriteLine("Enter the CVV on credit card");
            CVV = Console.ReadLine();
            int value = date.CompareTo(DateTime.Today);
            if (Card_number.Length == 16 && CVV.Length == 3 && value>0)
            {
                Card_number = reverse(Card_number);
                string sum = Sumandmul(Card_number);
                string mod = ModAndCheck(sum);
                Console.WriteLine(mod);
            }
            if(Card_number.Length!=16 || CVV.Length != 3)
                Console.WriteLine("Invalid Card Number/CVV");
            if(value < 0)
                Console.WriteLine("Date expired");
            
        }

        private string ModAndCheck(string sum)
        {
            int number = Convert.ToInt32(sum);
            if (number % 10 == 0)
                return "Valid Card/CVV";
            else
                return "Please verify correct number and CVV";
        }

        private string reverse(string number)
        {
            string output = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                output += number[i];
            }
            return output; 
        }
        private string Sumandmul(string number)
        {
            int num_convert, mul_, sum = 0,even_sum=0,odd_sum=0;
            for(int i = 0; i < number.Length; i++)
            {
                char v = number[i];
                num_convert = (int)Char.GetNumericValue(v);
                if ((i+1) % 2 == 0)
                {
                    mul_ = num_convert * 2;
                    if(mul_ >= 10)
                    {
                        while (mul_ > 0)
                        {
                            int n = mul_ % 10;
                            even_sum += n;
                            mul_ = mul_ / 10;
                        }
                    }
                    else
                        even_sum += mul_;
                }
                else
                {
                    odd_sum += num_convert;
                }
                sum = even_sum + odd_sum;
            }
            return Convert.ToString(sum);
        }

        static void Main(string[] args)
        {
            new Program().TakeUserData();
        }
    }
}
