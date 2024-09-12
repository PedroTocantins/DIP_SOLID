using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_SOLID.WithDIP;
internal class PaymentService(IPaymentProcessor processor)
{
    private readonly IPaymentProcessor _processor = processor;

    public void ProcessPayment()
    {
        _processor.ProcessPayment();
    }
}
