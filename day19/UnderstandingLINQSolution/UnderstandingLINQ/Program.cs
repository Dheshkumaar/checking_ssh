using System;
using System.Linq;

namespace UnderstandingLINQ
{
    class Program
    {
        int[] feedbackScores = { 90, 76, 45, 53, 1, 80, 22, 78, 99 };
        void PrintLowFeedbackCount()
        {
            var count = feedbackScores.Where(feedbackScores => feedbackScores < 60).Count();
            Console.WriteLine("The number of feedback that are less than 60 is "+count);
        }
        void PrintFeedbackInAscendingOrder()
        {
            var sortedFeedback = feedbackScores.OrderByDescending(score => score);
            Console.WriteLine("Printing sorted feedbacks");
            foreach (var item in sortedFeedback)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PrintLowFeedbackCount();
            program.PrintFeedbackInAscendingOrder();
            Console.WriteLine("Hello World!");
        }
    }
}
