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
        }
        public String Desc
        {
            get { return description; }
        }
        public DateTime Due
        {
            get { return dueDate; }
        }
        public DateTime Creation
        {
            get { return dueDate; }
        }
        public State TaskState
        {
            get { return taskState; }
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
