using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage72
{
    class Computation
    {
        static void Main(string[] args)
        {
            //constant
            int IS_PRSENT = 1;
            Random random = new Random();
            //using next() methad to genret rondom input out 0,1
            int empInput = random.Next(0, 2);
            //if_ese programing constact
            if (IS_PRSENT == empInput)
            {
                Console.WriteLine("Employee is prsent");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is absent ");
                Console.ReadLine();
            }
        }
    }
}