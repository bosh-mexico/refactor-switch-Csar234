using System;

namespace PaymentProcessing
{
    /// <summary>
    /// Concrete processor for GooglePay payments.
    /// </summary>
    public sealed class GooglePayProcessor : IPaymentProcessor
    {
        public void Process(double amount)
        {
            Console.WriteLine($"Processing GooglePay payment of ${amount:F2}");
        }
    }
}
