using System;

namespace WorkflowEngine_1
{
    internal class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage");
        }
    }
}
