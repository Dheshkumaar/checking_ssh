using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQEg
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(19);
            numbers.Add(30);
            numbers.Add(17);
            numbers.Add(15);
            numbers.Add(60);
            //query syntax
            var num1 = (from s in numbers
                        where s > 15
                        select s).OrderBy(s => s).ToList();
            //Method syntax
            var num = numbers.Where(s => s > 15).Select(s => s).OrderByDescending(s => s);
            foreach (var item in num1)
            {
                Console.WriteLine(item);
            }
            #endregion
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Kiwi");
            fruits.Add("Apricot");
            fruits.Add("Banana");
            fruits.Add("Avacoda");
            //Query syntax for LINQ
            var result = (from s in fruits
                          where s.Length < 6 || s.StartsWith("A")
                          select s).ToList();
            //Method syntax for LinQ
            var res = fruits.Where(s => s.StartsWith("A") || s.Length < 6).Select(s => s).OrderBy(s =>s);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}
