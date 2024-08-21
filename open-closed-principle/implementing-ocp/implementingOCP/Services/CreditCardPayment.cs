using implementingOCP.Services.Interfaces;

namespace implementingOCP.Services
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            System.Console.WriteLine("Implementing the credit card payment");
        }
    }
}