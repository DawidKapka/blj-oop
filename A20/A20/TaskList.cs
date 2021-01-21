using System;
using System.Collections.Generic;
using System.Text;

namespace A20
{
    public class TaskList
    {
        List<Task> tasks = new List<Task>();
        static int count = 0;

        public TaskList()
        {
            count++;
        }

        public List<Task> Tasks
        {
            get { return tasks; }
            set { tasks = value; }
        }

        public void Add(Task task)
        {
            tasks.Add(task);
        }
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
        public List<Task> Search(String searchCrit)
        {
            List<Task> tasksSearch = new List<Task>();
            foreach (Task task in tasks)
            {
                if (searchCrit.ToLower() == task.Title.ToLower() || searchCrit.ToLower() == task.Desc.ToLower() || searchCrit == task.Creation.ToString() || searchCrit == task.Due.ToString() || searchCrit.ToLower() == task.TaskState.ToString().ToLower())
                {
                    tasksSearch.Add(task);
                }
            }
            return tasksSearch;
        }
    }
}
