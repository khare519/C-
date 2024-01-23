using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StubUnitTesting
{
    // PaymentGateway interface
    public interface IPaymentGateway
    {
        bool ProcessPayment(decimal amount);
    }

    // PaymentProcessor class
    public class PaymentProcessor
    {
        private readonly IPaymentGateway paymentGateway;

        public PaymentProcessor(IPaymentGateway paymentGateway)
        {
            this.paymentGateway = paymentGateway;
        }

        public bool MakePayment(decimal amount)
        {
            // Some payment processing logic
            Console.WriteLine($"Processing payment for {amount}...");

            // Call the payment gateway
            return paymentGateway.ProcessPayment(amount);
        }
        public static void Main() { }
    }

    // Stub implementation of the PaymentGateway
    public class PaymentGatewayStub : IPaymentGateway
    {
        public bool ProcessPayment(decimal amount)
        {
            // Simulate a successful payment for the stub
            Console.WriteLine($"Stub: Simulating successful payment processing for {amount}.");
            return true;
        }
    }
    
}
