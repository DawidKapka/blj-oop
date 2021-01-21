using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A20
{
    public partial class Form1 : Form
    {
        bool isArchive = false;
        bool isSearch = false;
        public static TaskList tasks = new TaskList();
        List<Task> taskList = tasks.Tasks;
        public Form1()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            Form2 createForm = new Form2();
            createForm.ParentForm = this;
            createForm.Show();
            

        }

        public void UpdateTable()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            foreach (Task task in taskList)
            {
                if (task.TaskState != Task.State.Archived)
                {
                    int rowId = dataGridView.Rows.Add();
                    DataGridViewRow row = dataGridView.Rows[rowId];
                    if (DateTime.Compare(task.Due, DateTime.Now) <= 0 && task.TaskState != Task.State.Done && task.TaskState != Task.State.Archived)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    row.Cells["Title"].Value = Convert.ToString(task.Title);
                    row.Cells["Desc"].Value = Convert.ToString(task.Desc);
                    row.Cells["CreationDate"].Value = Convert.ToString(task.Creation);
                    row.Cells["DueDate"].Value = Convert.ToString(task.Due);
                    row.Cells["State"].Value = Convert.ToString(task.TaskState);
                }


            }
        }
        public void UpdateArchive()
        {
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            foreach (Task task in taskList)
            {
                if (task.TaskState == Task.State.Archived)
                {
                    int rowId = dataGridView.Rows.Add();
                    DataGridViewRow row = dataGridView.Rows[rowId];
                    row.Cells["Title"].Value = Convert.ToString(task.Title);
                    row.Cells["Desc"].Value = Convert.ToString(task.Desc);
                    row.Cells["CreationDate"].Value = Convert.ToString(task.Creation);
                    row.Cells["DueDate"].Value = Convert.ToString(task.Due);
                    row.Cells["State"].Value = Convert.ToString(task.TaskState);
                }


            }
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                Task task = null;
                foreach (Task t in taskList)
                {
                    if (t.Title == row.Cells["Title"].Value.ToString())
                    {
                        task = t;
                    }
                }
                EditForm editForm = new EditForm(task);
                editForm.ParentForm = this;
                editForm.Show();

            }
            

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                Task task = null;
                foreach (Task t in taskList)
                {
                    if (t.Title == row.Cells["Title"].Value.ToString())
                    {
                        task = t;
                    }
                }
                DialogResult result = MessageBox.Show("Delete '" + task.Title + "'?", "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    tasks.Remove(task);
                }
                if (isArchive)
                {
                    UpdateArchive();
                }
                else
                {
                    UpdateTable();
                }
                
            }

        }

        private void archButton_Click(object sender, EventArgs e)
        {
            if (!isArchive)
            {
                isArchive = true;
                archButton.Text = "Active";
                UpdateArchive();
            }
            else
            {
                isArchive = false;
                archButton.Text = "Archive";
                UpdateTable();
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!isSearch)
            {
                isSearch = true;
                searchButton.Text = "Show All";
                taskList = tasks.Search(searchBox.Text);
                UpdateTable();
            }
            else
            {
                isSearch = false;
                searchButton.Text = "Search";
                taskList = tasks.Tasks;
                UpdateTable();
            }

        }
    }
}
