﻿using System.Collections.Generic;

namespace WorkflowEngine
{
    internal class Workflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void RegisterActivities(IActivity activity)
        {
            _activities.Add(activity);
        }
        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}