using System;

namespace PaymentProcessing
{
    /// <summary>
    /// Null-object processor used to gracefully handle unsupported/invalid modes.
    /// </summary>
    public sealed class UnknownPaymentProcessor : IPaymentProcessor
    {
        public void Process(double amount)
        {
            Console.WriteLine("Invalid payment mode selected!");
        }
    }
}
