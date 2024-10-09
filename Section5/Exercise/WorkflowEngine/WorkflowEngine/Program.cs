using System;

namespace WorkflowEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            var workflow = new Workflow();
            workflow.RegisterActivities(new UploadVideo());
            workflow.RegisterActivities(new CallVideoEncodingService());
            workflow.RegisterActivities(new SendEmail()); 
            workflow.RegisterActivities(new ChangeVideoStatus());

            workflowEngine.Run(workflow);

        }
    }
}