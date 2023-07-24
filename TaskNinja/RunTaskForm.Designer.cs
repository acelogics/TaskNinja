namespace TaskNinja
{
    partial class RunTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.runNewTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(141, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 28);
            this.textBox1.TabIndex = 1;
            // 
            // runNewTask
            // 
            this.runNewTask.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.runNewTask.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runNewTask.Location = new System.Drawing.Point(455, 107);
            this.runNewTask.Name = "runNewTask";
            this.runNewTask.Size = new System.Drawing.Size(96, 36);
            this.runNewTask.TabIndex = 5;
            this.runNewTask.Text = "Run";
            this.runNewTask.UseVisualStyleBackColor = false;
            this.runNewTask.Click += new System.EventHandler(this.runNewTask_Click);
            // 
            // RunTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 179);
            this.Controls.Add(this.runNewTask);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "RunTaskForm";
            this.Text = "RunTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button runNewTask;
    }
}