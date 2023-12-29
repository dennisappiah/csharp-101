using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.OverridingMethods
{
    public class Employee
    {
        public decimal HourlyRate { get; set; }

        public virtual decimal GetPayAmount(int hoursWorked)
        {
            return HourlyRate * hoursWorked;
        }


    }
}
