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
            Wage byjus = new Wage("Byjus", 20, 8, 100);
            Wage extra = new Wage("microsoft", 20, 8, 100);
            byjus.CalculateWage();
            Console.WriteLine(byjus.ToString());
            extra.CalculateWage();
            Console.WriteLine(extra.ToString());
            Console.ReadLine(); 
        }
        
    }
}
