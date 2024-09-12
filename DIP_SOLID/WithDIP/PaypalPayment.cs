using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_SOLID.WithDIP;
internal class PaypalPayment : IPaymentProcessor
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Paypal payment...");
    }
}
