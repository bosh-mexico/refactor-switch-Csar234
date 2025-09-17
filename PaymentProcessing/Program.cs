using System;

namespace PaymentProcessing
{
    public static class Program
    {
        public static void Checkout(PaymentMode mode, double amount)
        {
            var processor = PaymentProcessorRegistry.Resolve(mode);
            processor.Process(amount);
        }

        public static void Main(string[] args)
        {
            double amount = 150.75;

            Checkout(PaymentMode.PayPal, amount);
            Checkout(PaymentMode.GooglePay, amount);
            Checkout(PaymentMode.CreditCard, amount);
            Checkout(PaymentMode.Unknown, amount);
        }
    }
}
