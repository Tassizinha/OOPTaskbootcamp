using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Hours { get; set; }
        public decimal ValuePerHour { get; set; }
        public decimal AdditionalCharge { get; set; }
        public decimal Payment { get; set; }

        public virtual void CalculatePayment()
        {
            Payment = (decimal)Hours * ValuePerHour;
        }

    }
}
