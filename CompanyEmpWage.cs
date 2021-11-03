using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage72.EmployeeWage
{
    class CompanyEmpWage
    {
        public string company;
        public int EmpRatePerHrs;
        public int Num_Of_Working_Days;
        public int WorkingHrs;
        public int totalEmpWage = 0;



        public CompanyEmpWage(string company, int EmpRatePerHrs, int Num_Of_Working_Days, int WorkingHrs)
        {
            this.company = company;
            this.EmpRatePerHrs = EmpRatePerHrs;
            this.Num_Of_Working_Days = Num_Of_Working_Days;
            this.WorkingHrs = WorkingHrs;

        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;

        }

        public string toString()
        {
            return "Total Emp Wage for Company :" + this.company + " is " + this.totalEmpWage;

            //Console.ReadLine();
        }

    }
}
