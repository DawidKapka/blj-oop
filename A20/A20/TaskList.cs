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
        }

        public void Add(Task task)
        {
            tasks.Add(task);
        }
        public void Remove(Task task)
        {

        }
        public List<Task> Search(String searchCrit)
        {
            return tasks;
        }
    }
}
