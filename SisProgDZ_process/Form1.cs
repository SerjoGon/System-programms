using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;

namespace SisProgDZ_process
{
    public partial class Form1 : Form
    {
        const uint WM_SETTEXT = 0x0C;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam,
            [MarshalAs(UnmanagedType.LPStr)] string lParam);
        List<Process> processes = new List<Process>();
        public Form1()
        {
            InitializeComponent();
        }
        private void procStarter()
        {
            Process process = Process.Start(textBox1.Text);
            processes.Add(process);
            if (Process.GetCurrentProcess().Id == GetParentProcessId(process.Id))
            {
                richTextBox1.Text += process.ProcessName + " дочерний процесс текущего процесса!\n";
            }
            

        }
        private void procKiller()
        {
            foreach (Process proc in processes)
            {
                richTextBox1.Text += proc.ProcessName.ToString() + proc.Id.ToString() + " завершен!\n";
                proc.Kill();
            }
            processes.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procStarter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            procKiller();
        }
        int GetParentProcessId(int Id)
        {
            int parentId = 0;
            using (ManagementObject obj = new ManagementObject(
                "win32_process.handle=" +
                Id.ToString()))
            {
                obj.Get();
                parentId = Convert.ToInt32(obj["ParentProcessId"]);
            }
            return parentId;
        }

        private void btn_waitproc_Click(object sender, EventArgs e)
        {
            foreach (Process proc in processes)
            {
                proc.WaitForExit();
            }
        }
    }
}