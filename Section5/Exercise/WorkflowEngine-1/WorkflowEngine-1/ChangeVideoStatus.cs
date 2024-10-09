using System;

namespace WorkflowEngine_1
{
    internal class ChangeVideoStatus : IActivity
    {
        public void Execute()
        {
           Console.WriteLine("Changing video status to Processing");
        }
    }
}
