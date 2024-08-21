using implementingOCP.Services;
using implementingOCP.Services.Abstraction;
using implementingOCP.Services.Interfaces;

Shape circle = new Circle();
Shape rectangle = new Rectangle();

IPaymentMethod creditCard = new CreditCardPayment();
IPaymentMethod payPal = new PayPalPayment();

PaymentProcessor paymentProcessor = new();

circle.Draw();
rectangle.Draw();
paymentProcessor.ProcessPayment(creditCard);
paymentProcessor.ProcessPayment(payPal);