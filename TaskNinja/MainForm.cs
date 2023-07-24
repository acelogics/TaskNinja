using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskNinja
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search Process...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Search Process...";
                textBox1.ForeColor = Color.Silver;
            }
        }

        public void GetAllProcesses()
        {
            // Clear existing rows in the DataGridView
            dataGridView1.Rows.Clear();

            // Get the list of running processes
            Process[] processes = Process.GetProcesses();

            // Populate the DataGridView with process information
            foreach (Process process in processes)
            {
                string id = process.Id.ToString();
                string name = process.ProcessName;
                string memoryUsage = (process.WorkingSet64 / (1024.0 * 1024.0)).ToString("N5"); // Convert bytes to MB and format as a number with a maximum of 5 digits

                string status = process.Responding ? "Running" : "Not Responding";

                dataGridView1.Rows.Add(name, id, status, memoryUsage);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           GetAllProcesses();

        }


        private void endTask_Click(object sender, EventArgs e)
        {

            try
            {
                Process process = Process.GetProcessById(Int32.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
                process.Kill();
               
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Error ending the task: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Refresh the DataGridView to update the task list
            GetAllProcesses();
        }

        private void runNewTask_Click(object sender, EventArgs e)
        {

            RunTaskForm runForm = new RunTaskForm();
            runForm.ShowDialog();

        }



        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform the search
                string searchTerm = textBox1.Text.Trim();
                SearchProcesses(searchTerm);
            }
        }

        private void SearchProcesses(string searchTerm)
        {
            // Loop through the DataGridView rows and filter based on the search term
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip the new row (uncommitted) in the DataGridView
                if (!row.IsNewRow)
                {
                    // Check the values in the desired columns (e.g., Name, PID, Status, MemUsage...) for the search term
                    bool found = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            found = true;
                            break;
                        }
                    }

                    // Set the visibility of the row based on whether the search term was found
                    row.Visible = found;
                }


            }

        }
    }
}   

