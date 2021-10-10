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
        public const int MAX_WORKING_DAYS =20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            //local ver
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int day = 1;
            int totalHrs = 0;
            Random random = new Random();
            while (day <= MAX_WORKING_DAYS&& totalHrs <= MAX_WORKING_HRS)
            {
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
                totalEmpWage += empWage;
               Console.WriteLine("Daily employee wage for {0} days: {1}, ", day, empWage);
                day++;
                totalHrs += empHrs; 
            }
                Console.WriteLine("Tolat Employee Wage for {0} days :{1} max warking hrs:",day-1,totalEmpWage,totalHrs);
                Console.ReadLine();
            
        }
    }
}