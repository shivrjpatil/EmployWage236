using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    internal class Wage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private string Company;
        private  int WagePerHour;
        private  int MaxWorkingDays;
        private  int MaxWorkingHour;
        private int totalwage;

        public Wage(string Company, int MaxWorkingDays, int MaxWorkingHour, int WagePerHour)
        {
            this.Company = Company;
            this.WagePerHour =WagePerHour;
            this.MaxWorkingDays = MaxWorkingDays;
            this.MaxWorkingHour = MaxWorkingHour;
        }
        public void CalculateWage()
            {
                int empwage = 0, emphrs = 0, day = 1,  totalhour = 0;

                Random random = new Random();

                while (day <=MaxWorkingDays && totalhour <= MaxWorkingHour)
                {
                    int EmpCheck = random.Next(0, 3);
                    switch (EmpCheck)
                    {

                        case FULL_TIME:
                            emphrs = 8;
                            break;

                        case PART_TIME:
                            emphrs = 4;
                            break;
                        default:
                            emphrs = 0;
                            break;
                    }
                    empwage = WagePerHour * emphrs;
                    totalwage += empwage;
                    totalhour += emphrs;
                    day++;
                }
                Console.WriteLine("Toatl wage for {3} {0} days:{1} and hour is {2}",totalwage,(day-1), totalhour,Company);
               
        }

        public string toString()
        {
            return "Total Emp Wage for company : " + this.Company + " is " + this.totalwage;
        }
    }
}
