using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage72
{
    //part timr employee wage and full time employee wage
    class Computation
    { 
        //constant
        public const int IS_FullTime = 1;
        public const int EMP_RET_PR_HR = 50;
        public const int IS_PART_TIME = 2;
        static void Main(string[] args)
        {
            //local ver
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //using next() methad to genret rondom input out 0,1
            int empInput = random.Next(0, 3);
            //if_ese programing constact
            if (IS_FullTime == empInput)
            {
                Console.WriteLine("Full time Employee is prsent");
                empHrs = 8;
            }
            else if (IS_PART_TIME == empInput)
            {
                Console.WriteLine("part time employee is prsent");
                empHrs = 4;
            } 

              else
            {
                Console.WriteLine("Employee is absent ");
                empHrs = 0;
            }
            empWage = EMP_RET_PR_HR * empHrs;
               Console.WriteLine("Employee Wage {0}" , empWage);
               Console.ReadLine();
        }
    }
}