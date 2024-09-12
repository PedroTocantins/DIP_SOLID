using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_SOLID.WithDIP;
public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment...");
    }
}
