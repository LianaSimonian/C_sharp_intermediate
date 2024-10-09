using System;

namespace WorkflowEngine
{
    internal class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage");
        }
    }
}