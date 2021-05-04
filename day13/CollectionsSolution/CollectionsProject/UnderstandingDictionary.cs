﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class UnderstandingDictionary
    {
        Dictionary<int, string> d1 = new Dictionary<int, string>();
        Dictionary<int, Movie> d2 = new Dictionary<int, Movie>();

        void AddItemsToDictionary()
        {
            d1.Add(101, "Ramu");
            d1.Add(102, "Somu");
            d2.Add(101, new Movie());
            d2[101].Id = 101;
            d2[101].TakeMovieDetails();
        }
        void OtherMethods()
        {
            bool result = d1.ContainsKey(101);
            Console.WriteLine("has key 101"+result);
            Console.WriteLine("Please enter a key to fetch value");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(d1[key]);
            Console.WriteLine("the count of dictionary is" +d1.Count);
        }
        void PrintDataFromDictionary()
        {
            foreach (var item in d1.Keys)
            {
                Console.WriteLine(item+" "+d1[item]);
            }
            Console.WriteLine("----------------------");
            foreach (var item in d2.Keys)
            {
                Console.WriteLine(item+" "+d2[item]);
            }
        }
        static void Main(string[] args)
        {
            UnderstandingDictionary ud = new UnderstandingDictionary();
            ud.AddItemsToDictionary();
            //ud.OtherMethods();
            ud.PrintDataFromDictionary();

        }
    }
}
