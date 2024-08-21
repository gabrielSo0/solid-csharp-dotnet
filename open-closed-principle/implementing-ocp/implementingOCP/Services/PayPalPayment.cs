using implementingOCP.Services.Interfaces;

namespace implementingOCP.Services
{
    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            System.Console.WriteLine("Implementing the PayPal payment method");
        }
    }
}