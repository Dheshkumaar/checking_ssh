using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class UnderstandingStack
    {
        Stack<string> myStack;
        public UnderstandingStack()
        {
            myStack = new Stack<string>();
        } 
        void AddItemstoStack()
        {
            myStack.Push("Red");
            myStack.Push("Blue");
            myStack.Push("Yellow");
            myStack.Push("Green");
        }
        void PrintStack()
        {
            Console.WriteLine(myStack.Count);
            //foreach(var item in myStack)
            //    Console.WriteLine(item);
            while (myStack.Count>0)
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine(myStack.Count);
        }
        static void Main(string[] args)
        {
            UnderstandingStack understandingStack = new UnderstandingStack();
            understandingStack.AddItemstoStack();
            understandingStack.PrintStack();
        }
    }
}
