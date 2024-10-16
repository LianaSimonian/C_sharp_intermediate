﻿using System.Collections.Generic;

namespace WorkflowEngine_1
{
    internal class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
