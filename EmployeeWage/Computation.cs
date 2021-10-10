using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage72
{
   
    class Computation
    { 
        //constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RET_PR_HR = 50;
        
        
        static void Main(string[] args)
        {
            //local ver
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //using next() methad to genret rondom input out 0,1
            int empInput = random.Next(0, 3);
            //switch cash  programing constact
            switch (empInput)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            } 
             // formula for calculating emp wage
            empWage = EMP_RET_PR_HR * empHrs;
               Console.WriteLine("Employee Wage {0}" , empWage);
               Console.ReadLine();
        }
    }
}