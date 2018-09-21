using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoSpil
{
    class Employee
    {
        public string Name{ get; set; }
        public double Salary { get; set; }

        public double Bonus (double Bonus)
        {
            double Result = this.Salary * Bonus;
            return Result;
        }
        public double Bonus()
        {
            double Result = this.Salary * 1.05;
            return Result;
        }


    }
}

