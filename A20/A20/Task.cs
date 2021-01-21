using System;
using System.Collections.Generic;
using System.Text;

namespace A20
{
    public class Task
    {
        String title;
        String description;
        DateTime dueDate;
        DateTime creationDate;
        State taskState;
        bool isArchived;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public String Desc
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Due
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public DateTime Creation
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        public State TaskState
        {
            get { return taskState; }
            set { taskState = value; }
        }
        public Task(String name, String desc, DateTime due, DateTime creation, State TState)
        {
            title = name;
            description = desc;
            dueDate = due;
            creationDate = creation;
            taskState = TState;

        }
        public bool Archived
        {
            set { isArchived = value; }
            get { return isArchived; }
        }

        public enum State
        {
            Todo,
            InProgress,
            Done,
            Archived
        }
    }
}
