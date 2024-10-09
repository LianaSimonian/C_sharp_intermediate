using System.Collections.Generic;

namespace WorkflowEngine_1
{
    internal interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
