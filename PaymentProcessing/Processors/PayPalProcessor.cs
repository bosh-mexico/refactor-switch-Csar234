using System;

namespace PaymentProcessing
{
    /// <summary>
    /// Concrete processor for PayPal payments.
    /// Encapsulates PayPal-specific behavior (placeholder for real API integration).
    /// </summary>
    public sealed class PayPalProcessor : IPaymentProcessor
    {
        public void Process(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount:F2}");
        }
    }
}
