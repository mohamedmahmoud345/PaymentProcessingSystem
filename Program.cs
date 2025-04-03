using System.Reflection;

namespace CAPaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paymentMethod =  PaymentProcess();

            var order = new Order(paymentMethod);
            Console.Write("Enter Amount: ");
            int amount = int.Parse(Console.ReadLine());
            order.SetAmount(amount);
         
        }
        public static IPaymentProcessor PaymentProcess()
        {
            // show payment methods
            Console.WriteLine("Select Payment Method: ");
            PaymentMethods();

            // get choice from user
            int choice ;
            Console.Write("Enter Choice: ");
            if (!int.TryParse(Console.ReadLine(), out choice) || choice <= 0)
            {
                Console.WriteLine("Invalide Input");
            }

            return ChoicePaymentMethod(choice);
        }
        public static void PaymentMethods()
        {
            var implementations = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IPaymentProcessor).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract).ToArray();
            for(var i = 0; i < implementations.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.{implementations[i].Name}");
            }            
        }
        public static IPaymentProcessor ChoicePaymentMethod(int choice)
        {

            IPaymentProcessor payment = choice switch
            {
                1 => new PayPalPayment(),
                2 => new PaymentsMethod(),
                3 => new BitcoinPayment(),
                _=> null
            };
            return payment;
        }
    }
 
}
