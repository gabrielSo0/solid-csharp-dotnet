namespace implementingOCP.Services.Interfaces
{
    /*
        To comply with OCP, you can introduce an interface for payment processing.

        Now, the PaymentProcessor class can be designed to work with any IPaymentMethod
    */
    public interface IPaymentMethod
    {
        void ProcessPayment();
    }
}