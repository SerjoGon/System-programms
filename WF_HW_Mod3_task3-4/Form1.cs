using Microsoft.VisualBasic.Devices;
using System.IO;

namespace WF_HW_Mod3_task3_4
{
    public partial class Form1 : Form
    {
        string filepath = "";
        //"F:\\Games\\Test folder\\test.txt";
        public Form1()
        {
            InitializeComponent();

        }

        void btn_filefind_Click(object sender, EventArgs e)
        {
            ofdFunction();
        }
        public void ofdFunction()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files (*.txt|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofd.FileName;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private async Task SearchInTxt(string path, string keyWord)
        {

            await Task.Run(() =>
            {
                try
                {
                    string str = File.ReadAllText(path);
                    List<string> splitText = str.Split(new Char[] { ' ', '.', ',', ':', '\t' }).ToList();
                    int counter = 0;
                    foreach (string s in splitText)
                    {
                        if (s.Trim() != "" && System.Text.RegularExpressions.Regex.IsMatch(s, keyWord))
                        {
                            richTextBox1.Text += splitText[splitText.IndexOf(keyWord)]+" ";
                            counter++;
                        }
                    }
                    lbl_count.Text = counter.ToString();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            });

        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
             await SearchInTxt(filepath,textBox1.Text);
        }
    }
}