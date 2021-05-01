using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingMoreOOPSProject
{
    class Manager:IManagerPersonal,ICustomerManager,IEmployeeManager
    {
        public void Eat()
        {
            Console.WriteLine("Food is everything");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzz");
        }
        public void ConductstaffMeeting()
        {
            Console.WriteLine("Conducts meeting..");
        }
        public void HandlesEmployees()
        {
            Console.WriteLine("Handles employees");
        }
        public void ApproveLoan()
        {
            Console.WriteLine("Approves Loan");
        }

        public void ResolveCustomerIssue()
        {
            Console.WriteLine("customer issue resolved.");
        }
    }
}
