using System;

namespace CET2007_Week3_Workshop
{
    public class CashPayment : IPaymentProcessor
    {
        public void ProcessPayment(double amount, string reference)
        {
            Console.WriteLine("Cash payment of £" + amount.ToString("F2") + " received for " + reference + ".");
        }
    }
}