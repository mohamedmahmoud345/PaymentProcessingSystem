namespace CAPaymentSystem
{
    class PaymentsMethod : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card Payment of {amount} ...");
            Console.WriteLine("Payment Successful!");
        }
    }
    class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal Payment of {amount} ...");
            Console.WriteLine("Payment Successful!");
        }
    }
    class BitcoinPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bitcoin Payment of {amount} ...");
            Console.WriteLine("Payment Successful!");
        }
    }
    class VisaPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Visa Payment of {amount} ...");
            Console.WriteLine("Payment Successful!");
        }
    }
}
