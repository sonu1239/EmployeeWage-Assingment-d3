using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage72.EmployeeWage
{
    class EmpWageCompute
    {
        private int numofcompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageCompute()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs)
        {
            companyEmpWageArray[this.numofcompany] = new CompanyEmpWage(company, EmpRatePerHrs, Num_Of_Working_Days, WorkingHrs);
            numofcompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numofcompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.empWageCompute(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());

            }
        }
        public int checkEmpTime(int empInput)
        {

            const int IS_FullTime = 1;
            const int IS_PartTime = 2;
            int empHrs = 0;

            switch (empInput)
            {
                case IS_FullTime:

                    return empHrs = 8;
                case IS_PartTime:

                    return empHrs = 4;

                default:

                    return empHrs = 0;
            }

        }
        private int empWageCompute(CompanyEmpWage companyEmpWage)
        {

            int totalEmpHrs = 0, empHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.WorkingHrs && totalWorkingDays < companyEmpWage.Num_Of_Working_Days)
            {
                Random r = new Random();
                int empInput = r.Next(0, 3);
                //Console.WriteLine(empInput);
                empHrs = checkEmpTime(empInput);

                //int empWage = EmpRatePerHrs * empHrs;
                totalEmpHrs += empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs: " + empHrs);

            }

            return totalEmpHrs * companyEmpWage.EmpRatePerHrs;

        }
    }
}
