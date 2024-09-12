using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_SOLID.WithoutDIP;
public class PaymentService
{
    private CreditCardPayment creditCard;
    private PaypalPayment paypalPayment;

    public PaymentService()
    {
        this.creditCard = new CreditCardPayment();
        this.paypalPayment = new PaypalPayment();
    }

    public void ProcessPayment(string paymentMethod)
    {
        if (paymentMethod == "CreditCard")
        {
            creditCard.CreditCardPaymentProcessor();
        }
        else if (paymentMethod == "PayPal")
        {
            paypalPayment.PaypalPaymentProcessor();
        }
        else
        {
            Console.WriteLine("Unknown payment method.");
        }
    }
}
