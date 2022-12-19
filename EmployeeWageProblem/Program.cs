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
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            int empwage=0,emphrs = 0;

            Random random = new Random();
            int EmpCheck = random.Next(0, 3);

            if (FULL_TIME == EmpCheck)
            {
                Console.WriteLine("Full time Employee is present");
                emphrs = 8;
            }
            else if(PART_TIME == EmpCheck)
            {
                Console.WriteLine("Part time employee is present");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent ");
                emphrs = 0;
            }
            empwage = WAGE_PER_HOUR * emphrs;
            Console.WriteLine("Employee wage is :"+empwage);
            Console.ReadLine();
        }
    }
}
