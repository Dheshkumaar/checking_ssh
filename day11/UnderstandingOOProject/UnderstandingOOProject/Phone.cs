using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Phone
    {
        public string Color { get; set; } //prorperty

        public Phone()
        {
            Console.WriteLine("phone created");
        }
        public void CheckWorkPublic()
        {
            Console.WriteLine("Public Method");
        }
        protected void CheckWorkProtected()
        {
            Console.WriteLine("Protected Method");
        }
        internal void CheckWorkInternal()
        {
            Console.WriteLine("Internal");
        }
        private void CheckWorkPrivate()
        {
            Console.WriteLine("Private Method");
        }
    }
}
