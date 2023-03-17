namespace WF_HW_Mod3_task3_4
{
    public  partial class Form1 : Form
    {
        public  Form1()
        {
            InitializeComponent();
        }

        async void btn_filefind_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(() => { Task task = ofdFunction(); });
        }
        public async Task ofdFunction()
        {
            await Task.Run(async () =>
            {
                try
                {

                     OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "Text Files (*.txt|*.txt|All files (*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        await SearchInTxt(ofd.FileName, textBox1.Text);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            });

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
                            richTextBox1.Text += splitText[splitText.IndexOf(keyWord)];
                            counter++;
                        }
                    }
                    lbl_count.Text = counter.ToString();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            });

        }
    }
}