using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.OverridingMethods
{
    public class CommissionEmployee: Employee
    {
        public decimal CommissionRate { get; set; }


        //public override ->tap
        public override decimal GetPayAmount(int hoursWorked)
        {
            decimal initailPay = base.GetPayAmount(hoursWorked);

            return initailPay + CommissionRate;
        }



    }
}
