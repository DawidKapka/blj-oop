using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A20
{
    public partial class EditForm : Form
    {
        Task task;
        public EditForm(Task Task)
        {
            InitializeComponent();
            stateBox.Items.Add(Task.State.Todo);
            stateBox.Items.Add(Task.State.InProgress);
            stateBox.Items.Add(Task.State.Done);
            stateBox.Items.Add(Task.State.Archived);
            task = Task;
            titleBox.Text = task.Title;
            descBox.Text = task.Desc;
            crDateLabel.Text = task.Creation.ToString();
            dueDatePicker.Value = task.Due;
            stateBox.SelectedItem = task.TaskState;


        }
        public Form1 ParentForm { get; set; }
        private void saveButton_Click(object sender, EventArgs e)
        {
            task.Title = titleBox.Text;
            task.Desc = descBox.Text;
            task.Creation = DateTime.Parse(crDateLabel.Text);
            task.Due = dueDatePicker.Value;
            task.TaskState = (Task.State)stateBox.SelectedItem;
            if (ParentForm != null)
            {
                ParentForm.UpdateTable();
            }
            this.Close();

        }

    }
}
