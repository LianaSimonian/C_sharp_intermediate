namespace WorkflowEngine_1
{
    internal class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}
