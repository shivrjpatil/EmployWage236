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
            const int MAX_WORKING_DAYS = 20;
            int empwage = 0, emphrs = 0, day = 0, totalwage = 0;

            Random random = new Random();
            

            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int EmpCheck=random.Next(0, 3);
                switch (EmpCheck)
                {

                    case FULL_TIME:
                        Console.WriteLine("Full time Employee is present");
                        emphrs = 8;
                        break;

                    case PART_TIME:
                        Console.WriteLine("Part time employee is present");
                        emphrs = 4;
                        break;
                    default:
                        Console.WriteLine("employee is absent");
                        emphrs = 0;
                        break;
                }

                empwage = WAGE_PER_HOUR * emphrs;
                totalwage += empwage;
               Console.WriteLine("Employee wage is :" + empwage);
            }
            
            Console.WriteLine("Toatl wage for {0} days:{1}",(day-1),totalwage);
            Console.ReadLine();
        }
    }
}
