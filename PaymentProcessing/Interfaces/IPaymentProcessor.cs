namespace PaymentProcessing
{
    /// <summary>
    /// Abstraction for payment processing strategies.
    /// Each concrete payment mode implements this contract.
    /// </summary>
    public interface IPaymentProcessor
    {
        void Process(double amount);
    }
}
