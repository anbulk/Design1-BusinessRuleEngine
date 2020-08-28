using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class Order
    {
        public Order()
        {
            ProcessingOutcome = new List<string>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public Product Product { get; set; }
        public IPayment Payment { get; set; }
        public List<string> ProcessingOutcome { get; set; }
        public List<IRule> rules { get; set; }

        public bool ProcessOrder(IPayment payment)
        {
            Payment = payment;

           if ( Payment.ProcessPayment())
            {
                //Do Business Rules Based on Product
                foreach(IRule r in rules)
                {
                    r.PostPaymentProcess(this);
                }

            }

            return true;
        }
    }
}
