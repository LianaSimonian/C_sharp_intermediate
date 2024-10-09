using System;

namespace WorkflowEngine_1
{
    internal class SendEmail : IActivity
    {
        public void Execute()
        {
          Console.WriteLine("Sending email to the video owner ");
        }
    }
}
