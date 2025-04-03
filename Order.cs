namespace CAPaymentSystem
{
    class Order
    {
        private IPaymentProcessor processor;

        public Order(IPaymentProcessor processor)
        {
            this.processor = processor;
        }

        public void SetAmount(decimal amount)
        {
            processor.ProcessPayment(amount);
        }

    }
 
}
