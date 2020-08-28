using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface IPayment
    {
        bool ProcessPayment();
    }

    public enum PaymentTypeValue
    {
        GPay,
        NetBanking,
        Paytm

    }
}
