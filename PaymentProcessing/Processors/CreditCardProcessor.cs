using System;

namespace PaymentProcessing
{
    /// <summary>
    /// Concrete processor for Credit Card payments.
    /// </summary>
    public sealed class CreditCardProcessor : IPaymentProcessor
    {
        public void Process(double amount)
        {
            Console.WriteLine($"Processing Credit Card payment of ${amount:F2}");
        }
    }
}
