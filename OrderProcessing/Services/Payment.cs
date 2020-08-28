using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class GPayPayment:IPayment
    {
        public string PaymentRefrenceNumber { get; set; }
        public PaymentTypeValue PaymentType { get; set; }

        public GPayPayment()
        {
            PaymentType = PaymentTypeValue.GPay;
        }

        public bool ProcessPayment()
        {
            return true;
        }
        
    }
}
