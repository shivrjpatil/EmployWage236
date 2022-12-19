using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Employeewage Computation");
            const int PresentCheck = 1;
            const int FULL_DAY_HOUR = 8;
            const int WAGE_PER_HOUR = 20;
            int EMPLOYEE_WAGE = 0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (PresentCheck == EmpCheck)
            {
                Console.WriteLine("Employee is present");

                EMPLOYEE_WAGE = FULL_DAY_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("employee wage is :" + EMPLOYEE_WAGE);
            }
            else
            {
                Console.WriteLine("Employee is absent ");
                EMPLOYEE_WAGE = 0;
            }
            Console.ReadLine();
        }
    }
}
