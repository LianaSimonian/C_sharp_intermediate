using System;

namespace WorkflowEngine
{
    internal class ChangeVideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing video status to Processing");
        }
    }
}
