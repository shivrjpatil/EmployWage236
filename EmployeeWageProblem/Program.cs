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
            int PresentCheck = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (PresentCheck == EmpCheck)
            {
                Console.WriteLine("Employee is present");
            }
            else
                Console.WriteLine("Employee is absent ");
            Console.ReadLine();
        }
    }
}
