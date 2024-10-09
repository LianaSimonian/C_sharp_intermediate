using System;

namespace WorkflowEngine
{
    internal class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending email to the video owner ");
        }
    }
}
