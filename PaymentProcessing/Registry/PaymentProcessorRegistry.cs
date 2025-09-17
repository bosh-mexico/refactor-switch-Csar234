using System.Collections.Generic;

namespace PaymentProcessing
{
    /// <summary>
    /// Central registry (composition root) that maps PaymentMode to processors.
    /// </summary>
    public static class PaymentProcessorRegistry
    {
        private static readonly IReadOnlyDictionary<PaymentMode, IPaymentProcessor> _map =
            new Dictionary<PaymentMode, IPaymentProcessor>
            {
                { PaymentMode.PayPal,     new PayPalProcessor() },
                { PaymentMode.GooglePay,  new GooglePayProcessor() },
                { PaymentMode.CreditCard, new CreditCardProcessor() },
                { PaymentMode.Unknown,    new UnknownPaymentProcessor() }
            };

        private static readonly IPaymentProcessor _unknown = new UnknownPaymentProcessor();

        public static IPaymentProcessor Resolve(PaymentMode mode)
        {
            try
            {
                return _map[mode];
            }
            catch (KeyNotFoundException)
            {
                return _unknown;
            }
        }
    }
}
