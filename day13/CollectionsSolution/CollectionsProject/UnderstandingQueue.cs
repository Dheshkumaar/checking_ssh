using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    class UnderstandingQueue
    {
        Queue<string> myQueue;
        public UnderstandingQueue()
        {
            myQueue = new Queue<string>();
        }
        void AddItemstoQueue()
        {
            myQueue.Enqueue("Red");
            myQueue.Enqueue("Blue");
            myQueue.Enqueue("Yellow");
            myQueue.Enqueue("Green");
        }
        void PrintQueue()
        {
            Console.WriteLine(myQueue.Count);
            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine(myQueue.Count);
        }
        static void Main(string[] args)
        {
            UnderstandingQueue understandingqueue = new UnderstandingQueue();
            understandingqueue.AddItemstoQueue();
            understandingqueue.PrintQueue();
        }
    }
}
