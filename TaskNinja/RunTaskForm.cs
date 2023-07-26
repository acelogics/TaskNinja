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

namespace TaskNinja
{
    public partial class RunTaskForm : Form
    {
        public RunTaskForm()
        {
            InitializeComponent();
        }

        private void runNewTask_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                //run new task
                //MainForm form = new MainForm();

                try
                {
                    Process processs = new Process();
                    processs.StartInfo.FileName = textBox1.Text;
                    processs.Start();  
                }
                catch(Exception ex)                 {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                 // Refresh the DataGridView to update the task list
                //form.GetAllProcesses();
            }
        }
    }
}
