using System;

namespace Polymorphism
{
    internal class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS ");
        }
    }
}
