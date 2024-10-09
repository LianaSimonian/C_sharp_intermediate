
namespace WorkflowEngine
{
    internal class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
                activity.Execute();
        }
    }
}