namespace CET2007_Week3_Workshop
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount, string reference);
    }
}