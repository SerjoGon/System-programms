using System.Diagnostics;

namespace ProcessShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            if(listbox_process.SelectedIndex != -1)
            {
                Process[] processesByName = Process.GetProcessesByName(listbox_process.Items[listbox_process.SelectedIndex].ToString());
                if(processesByName.Length > 0)
                {
                    lb_procID.Text = processesByName[0].Id.ToString();
                    lbl_timeStart.Text = processesByName[0].StartTime.ToString("HH:m:s:ffff");
                }
            }
        }
    }
}