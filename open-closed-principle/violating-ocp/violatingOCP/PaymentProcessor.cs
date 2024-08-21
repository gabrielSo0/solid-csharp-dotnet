using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace violatingOCP
{
    public class PaymentProcessor
    {
        /*
            Imagine you have a payment processing system that initially supports only credit card payments.

            If you later decide to support PayPal payments, you need to modify the ProcessPayment method;

            Again, you are breaking the open closed principle. You can't extend the class and you are modifying the source code.
            This modification can cause bugs, non-funcional things. So, avoid modifying existing code to add new features or
            implementations.
        */
        public void ProcessPayment(string paymentType)
        {
            if(paymentType == "CreditCard")
            {
                // credit card logic
            }
            else if(paymentType == "PayPal")
            {
                // paypal logic
            }
        }
    }
}