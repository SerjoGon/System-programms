using System.Diagnostics;

namespace ProcessShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Process killprocess = new Process(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateProcessesList();
        }
        public void UpdateProcessesList()
        {
            Process[] processes = Process.GetProcesses();
            listbox_process.Items.Clear();
            foreach (Process process in processes)
            {
                listbox_process.Items.Add(process.ProcessName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessesList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(textBox1.Text) * 1000;
        }

        private void lb_process_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_process.SelectedIndex != -1)
            {
                int orderNumber = 0;
                int counter = 0;
                foreach(object obj in listbox_process.Items)
                {
                    if((string)obj == listbox_process.Items[listbox_process.SelectedIndex].ToString())
                    {
                        if(counter == listbox_process.SelectedIndex) { break; } 
                        orderNumber++;
                    }
                    counter++;
                }
                Process[] processesByName = Process.GetProcessesByName(listbox_process.Items[listbox_process.SelectedIndex].ToString());
                if (processesByName.Length > 0)
                {
                    killprocess = processesByName[0];
                    lb_procID.Text = processesByName[0].Id.ToString();
                    lbl_timeStart.Text = processesByName[0].StartTime.ToString("HH:m:s:ffff");
                    lbl_procTime.Text = processesByName[0].TotalProcessorTime.ToString();
                    lbl_threadcount.Text = processesByName[0].Threads.Count.ToString();
                    lbl_proccopy.Text = processesByName.Count().ToString();
                    lbl_heshcode.Text = processesByName[0].GetHashCode().ToString();
                }
                /*foreach (Process proc in processesByName)
                {
                    MessageBox.Show(proc.GetHashCode().ToString());
                }*/

            }
        }

        private void btn_killproc_Click(object sender, EventArgs e)
        {
            killprocess.Kill();
        }

        private void tb_createnewproc_TextChanged(object sender, EventArgs e)
        {
            if(tb_createnewproc.Text.Length > 0)
            {
                btn_createnewproc.Enabled = true; 
            }
            else
            {
                btn_createnewproc.Enabled = false; 
            }
        }

        private void btn_createnewproc_Click(object sender, EventArgs e)
        {
            Process process= new Process();
            process.StartInfo = new ProcessStartInfo(tb_createnewproc.Text);
            process.Start();
        }
    }
}