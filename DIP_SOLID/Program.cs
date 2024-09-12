using DIP_SOLID.WithDIP;

IPaymentProcessor processor = new CreditCardPayment();
IPaymentProcessor processorPaypal = new PaypalPayment();


processor.ProcessPayment();
processorPaypal.ProcessPayment();
