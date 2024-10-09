
namespace WorkflowEngine_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new UploadVideo());
            workflow.Add(new CallVideoEncodingService());
            workflow.Add(new SendEmail());
            workflow.Add(new ChangeVideoStatus());

            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
