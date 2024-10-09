using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class MailNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending mail");
        }
    }
}
