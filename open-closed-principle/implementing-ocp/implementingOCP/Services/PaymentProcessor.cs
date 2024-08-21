using implementingOCP.Services.Interfaces;

namespace implementingOCP.Services
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentMethod)
        {
            paymentMethod.ProcessPayment();
        }
    }
}