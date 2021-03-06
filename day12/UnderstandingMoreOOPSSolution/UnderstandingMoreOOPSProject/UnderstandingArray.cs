using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class UnderstandingArray
    {
        void UnderstandingSingleDimArray()
        {
            int[] intArr = new int[5];
            for(int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine("Please enter a number:");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You entered 5 numbers");
            foreach(int item in intArr)
            {
                Console.WriteLine(item);
            }
        }

        void UnderstandingMultiDimArray()
        {
            string[,] strArr = new string[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for(int j=0;j<3;j++)
                {
                    strArr[i, j] = Console.ReadLine();
                }
            }
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(strArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        void UnderstandingJaggedArray()
        {
            int[][] intArr = new int[3][];
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine("Please enter the no of columns of row " + i);
                int size = Convert.ToInt32(Console.ReadLine());
                intArr[i] = new int[size];
            }
            
            for (int i = 0; i < intArr.Length; i++)
            {
                for (int j = 0; j < intArr[i].Length; j++)
                {
                    intArr[i][j] = (i - 1) * j +10 -1;

                    Console.Write(intArr[i][j]+ " ");
                }
                Console.WriteLine();
             }
         }
        static void Main(string[] args)
        {
            new UnderstandingArray().UnderstandingJaggedArray();
        }
    }
        
}
