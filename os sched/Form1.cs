using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace os_sched
{
    public partial class input_form : Form
    {

        public List<process> P = new List<process>();


        public List<TextBox> burst_time = new List<TextBox>();
        public static List<int> burst_int = new List<int>();

        List<TextBox> arrival_time = new List<TextBox>();
        public static List<int> arrival_int = new List<int>();

        List<TextBox> priority = new List<TextBox>();
        public List<int> priority_int = new List<int>();

        public int n_process=0;
        public string method_type="";
        public int q_time;


        public Boolean flag=true;


       
        public input_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            q_label.Visible = false;
            q_text.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void n_processes_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(n_processes.Text, "^[0-9]{1,5}$").Success)
            {
                n_process = int.Parse(n_processes.Text);
                // MessageBox.Show(n_process.ToString());
                flag = true;
                if (method_type.Length != 0)
                {
                    if (flag == true)
                    {
                        flag = false;
                        take_processes_data();
                    }
                    else deactivate_unNecessary();
                }

            }
            else if (n_processes.Text=="") { MessageBox.Show("plese enter number of processes");
                n_processes.Text = "";
                n_processes.Focus();
                n_process = 0;
                flag = true;
                if (method_type.Length != 0)
                {
                    if (flag == true)
                    {
                        flag = false;
                        take_processes_data();
                    }
                    else deactivate_unNecessary();
                }

            }

            else {

                MessageBox.Show("only positive intger");
                n_processes.Text = "";
                n_processes.Focus();
                

            }
        }

        private void method_SelectedIndexChanged_1(object sender, EventArgs e)
        {
       
            method_type = method.Text;
           // MessageBox.Show(method_type);
            if (method_type.Length != 0)
            {
                if (flag == true)
                {
                    flag = false;
                    take_processes_data();
                }
                else deactivate_unNecessary();

            }
        }



        private void take_processes_data()
        {
            // MessageBox.Show("take process");
            //reset
            groupBox1.Controls.Clear();
            groupBox1.Size = new System.Drawing.Size(520, 130);
           // this.Size = new System.Drawing.Size(628, 290);
            burst_time.Clear();
            arrival_time.Clear();
            priority.Clear();
            if (n_process== 0) return;

            int x = 15, y = 20;//relative to groupBox

            Label write_arrival = new Label();
            write_arrival.Text = "arrival time";
            write_arrival.Size = new System.Drawing.Size(120, 20);
            write_arrival.Location = new System.Drawing.Point(x + 360 + 20, y);
            this.groupBox1.Controls.Add(write_arrival);

            Label write_bur_time = new Label();
            write_bur_time.Text = "burst time";
            write_bur_time.Size = new System.Drawing.Size(120, 20);
            write_bur_time.Location = new System.Drawing.Point(x + 120, y);
            this.groupBox1.Controls.Add(write_bur_time);

            Label prio = new Label();
            prio.Text = "priority";
            prio.Size = new System.Drawing.Size(120, 20);
            prio.Location = new System.Drawing.Point(x + 240 + 10, y);
            this.groupBox1.Controls.Add(prio);


            for (int i = 0; i < n_process; ++i)
            {
                // int x = (i!=0) ? burst_time[i - 1].Location.X : 15;
                //  int y = (i != 0) ? burst_time[i - 1].Location.Y+30 : 20;

                Label name = new Label();
                name.Text = "process" + (i + 1).ToString();
                name.Size = new System.Drawing.Size(120, 20);
                name.Location = new System.Drawing.Point(x, y + ((i + 1) * 35));
                this.groupBox1.Controls.Add(name);

                TextBox bur = new TextBox();
                burst_time.Add(bur);
                burst_time[i].Location = new System.Drawing.Point(x + 120, y + (i + 1) * 35);
                burst_time[i].Size = new System.Drawing.Size(120, 20);
                burst_time[i].MaxLength = 3;

                this.groupBox1.Controls.Add(burst_time[i]);

                TextBox pr = new TextBox();
                priority.Add(pr);
                priority[i].Location = new System.Drawing.Point(x + 240 + 10, y + (i + 1) * 35);
                priority[i].Size = new System.Drawing.Size(120, 20);
                priority[i].MaxLength = 3;

                this.groupBox1.Controls.Add(priority[i]);

                TextBox arr = new TextBox();
                arrival_time.Add(arr);
                arrival_time[i].Location = new System.Drawing.Point(x + 360 + 20, y + (i + 1) * 35);
                arrival_time[i].Size = new System.Drawing.Size(120, 20);
                arrival_time[i].MaxLength = 3;
                this.groupBox1.Controls.Add(arrival_time[i]);


                groupBox1.Size = new System.Drawing.Size(groupBox1.Size.Width, groupBox1.Size.Height + 35);
               // this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + 35);
            }
            y += (n_process+ 1) * 35;

            //button Run
            Button run = new Button();
            run.Size = new System.Drawing.Size(120, 50);
            run.Location = new System.Drawing.Point(x + 10 + 240, y);
            run.Text = "Run";
            run.Name = "run";
            run.Click += new System.EventHandler(this.run_Click);
            this.groupBox1.Controls.Add(run);
            run.Font = new Font("Lucida Calligraphy", 17, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            run.ForeColor = Color.White;
            run.BackColor = Color.DeepSkyBlue;
            deactivate_unNecessary();
        }

       

        private void deactivate_unNecessary()
        {
            //MessageBox.Show("re");
            if (n_process == 0) return;
            if (method_type != "RR")
            {
                this.q_label.Visible = false;
                q_text.Visible = false;
            }
            else
            {
                this.q_text.Visible = true;
                q_label.Visible = true;
            }

            if (method_type != "Priority (non pre-emptive)" && method_type != "Priority (pre-emptive)")
            {
                for (int i = 0; i < n_process; ++i)
                {
                    priority[i].Enabled = false;
                }
            }
            else if (!priority[0].Enabled)
            {
                for (int i = 0; i < n_process; ++i)
                {
                    priority[i].Enabled = true;
                }
            }
        }


        

        private void run_Click(object sender, EventArgs e)
        {
            try
            {
                fill_int();
                fill_process();
             //  draw(); //new form the output
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void fill_int()
        {
            if (method_type == "RR")
            {
                if (q_text.Text == "")
                {
                    Exception e = new Exception("please fill Q time field");
                    throw (e);
                }
                // //////
                else if (Regex.Match(q_text.Text, "^[1-9]{1,5}$").Success)
                {
                    q_time = int.Parse(q_text.Text);

                }

                else
                {
                    Exception e = new Exception("Only +ve intger allowed in Q time  field  1:999");
                    q_text.Text = "";
                    q_text.Focus();
                    throw (e);
                    
                }
                // ///
            }
            if (method_type == "Priority (non pre-emptive)" || method_type == "Priority (pre-emptive)")
            {
                priority_int.Clear();
                for (int i = 0; i < n_process; ++i)
                {
                    if (priority[i].Text == "")
                    {
                        Exception e = new Exception("please fill Priority  field of process"+(i+1).ToString());
                        throw (e);
                    }
                      else if (Regex.Match(priority[i].Text, "^[0-9]{1,5}$").Success)
                    {
                        priority_int.Add(int.Parse(priority[i].Text)); 

                    }

                    else
                    {
                        Exception e = new Exception("invaled priorty of process" + (i + 1).ToString()+" priorty range 0:999");
                        priority[i].Text = "";
                        priority[i].Focus();
                        throw (e);

                    }
                }
            }

            arrival_int.Clear();
            burst_int.Clear();
            for (int i = 0; i < n_process; ++i)
            {
                if (arrival_time[i].Text == "")
                {
                    Exception e = new Exception("please fill arrival time field of process" + (i + 1).ToString());
                    throw (e);
                }

               
                 else if (Regex.Match(arrival_time[i].Text, "^[0-9]{1,5}$").Success)
                {
                    arrival_int.Add(int.Parse(arrival_time[i].Text));

                }

                else
                {
                    Exception e = new Exception("invaled arrival time of process" + (i + 1).ToString() + " burst time range 0:999");
                    arrival_time[i].Text = "";
                    arrival_time[i].Focus();
                    throw (e);

                }

                burst_int.Add(Int32.Parse(burst_time[i].Text));
                if (burst_time[i].Text == "")
                {
                    Exception e = new Exception("please fill burst time field of process" + (i + 1).ToString());
                    throw (e);
                }

                else if (Regex.Match(burst_time[i].Text, "^[0-9]{1,5}$").Success)
                {
                    burst_int.Add(int.Parse(burst_time[i].Text));

                }

                else
                {
                    Exception e = new Exception("invaled burst time of process" + (i + 1).ToString() + " burst time range 0:999");
                    burst_time[i].Text = "";
                    burst_time[i].Focus();
                    throw (e);

                }
            }
        }



        private void fill_process()
        {for(int i = 0; i< n_process; i++)
            { P[i].arrival =arrival_int[i];
                P[i].burst = burst_int[i];
                P[i].priority = priority_int[i];
                P[i].id = i;

            }
        }
    }


    


   

}
