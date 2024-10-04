using System;

namespace WorkflowEngine
{
    internal class CallVideoEncodingService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call videoEncoding service ");
        }
    }
}
