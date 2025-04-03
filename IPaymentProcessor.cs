namespace CAPaymentSystem
{
    interface IPaymentProcessor 
    {
        void ProcessPayment(decimal amount);
    }
}
