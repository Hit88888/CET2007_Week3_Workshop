using System;

namespace CET2007_Week3_Workshop
{
    public class EmailNotifier : INotifier
    {
        public void Notify(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
}