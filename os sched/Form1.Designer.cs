namespace os_sched
{
    partial class input_form
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
            this.method = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.q_text = new System.Windows.Forms.TextBox();
            this.n_processes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.q_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // method
            // 
            this.method.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method.FormattingEnabled = true;
            this.method.Items.AddRange(new object[] {
            "FCFS",
            "Priority (non pre-emptive)",
            "Priority (pre-emptive)",
            "RR",
            "SJF (non pre-emptive)",
            "SJF (pre-emptive)"});
            this.method.Location = new System.Drawing.Point(280, 53);
            this.method.Name = "method";
            this.method.Size = new System.Drawing.Size(179, 28);
            this.method.TabIndex = 2;
            this.method.SelectedIndexChanged += new System.EventHandler(this.method_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Methoud";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // q_text
            // 
            this.q_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_text.Location = new System.Drawing.Point(509, 53);
            this.q_text.MaxLength = 3;
            this.q_text.Name = "q_text";
            this.q_text.Size = new System.Drawing.Size(179, 26);
            this.q_text.TabIndex = 3;
            // 
            // n_processes
            // 
            this.n_processes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_processes.Location = new System.Drawing.Point(51, 53);
            this.n_processes.MaxLength = 5;
            this.n_processes.Name = "n_processes";
            this.n_processes.Size = new System.Drawing.Size(179, 26);
            this.n_processes.TabIndex = 1;
            this.n_processes.TextChanged += new System.EventHandler(this.n_processes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "num of processes";
            // 
            // q_label
            // 
            this.q_label.AutoSize = true;
            this.q_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_label.Location = new System.Drawing.Point(567, 19);
            this.q_label.Name = "q_label";
            this.q_label.Size = new System.Drawing.Size(55, 20);
            this.q_label.TabIndex = 8;
            this.q_label.Text = "Q time";
            this.q_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 268);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processes information";
            // 
            // input_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 20);
            this.ClientSize = new System.Drawing.Size(715, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.q_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_processes);
            this.Controls.Add(this.q_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.method);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "input_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OS Schedular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox method;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q_text;
        private System.Windows.Forms.TextBox n_processes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label q_label;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

