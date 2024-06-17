using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    class Outsourced : Employee
    {
            public override void CalculatePayment()
            {
                base.CalculatePayment();
                Payment = (Hours * ValuePerHour) + AdditionalCharge + (0.16m * (Hours * ValuePerHour + AdditionalCharge));
            }
        
    }
}