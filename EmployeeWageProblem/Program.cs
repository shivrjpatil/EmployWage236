using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Employeewage Computation");
            Wage wage = new Wage();
            wage.CalculateWage("microsoft",25,12,120);
            Wage wage1 = new Wage();
            wage1.CalculateWage("google",20,8,100);
            Wage wage2 = new Wage();
            wage2.CalculateWage("Facebook",23,10,150);
            Console.ReadLine(); 
        }
        
    }
}
