using System;

namespace CET2007_Week3_Workshop
{
    public class SmsNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }
}