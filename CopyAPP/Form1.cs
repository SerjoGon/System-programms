namespace CopyAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_origpath.Text = Directory.GetCurrentDirectory();
            tb_targetpath.Text = Directory.GetCurrentDirectory();
        }

        private void btn_origpath_Click(object sender, EventArgs e)
        {
            OFD.FileName = Directory.GetCurrentDirectory();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                tb_origpath.Text = OFD.FileName;
                tb_targetpath.Text = OFD.FileName;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(tb_origpath.Text, FileMode.Open);
            FileStream fswrite = new FileStream(tb_targetpath.Text, FileMode.OpenOrCreate);
            byte[] b;
            long lengthfile = fs.Length;
            progressBar1.Maximum = (int)lengthfile;
            progressBar1.Minimum = 0;
            int countoperation = 100;
            long[] partsfilelength = new long[countoperation];
            for (int i = 0; i < countoperation; i++)
            {
                partsfilelength[i] = fs.Length / countoperation;
                if(i == countoperation -1 )
                {
                    partsfilelength[i] += lengthfile%countoperation;
                }
            }
            long pbvalue = 1;
                if(lengthfile > 1000)
            {
                pbvalue = lengthfile/1000;
            }
            foreach (long i in partsfilelength)
            {
                b = new byte[i];
                fs.Read(b, 0, b.Length);
                fswrite.Write(b, 0, b.Length);
                progressBar1.Value = (int)(lengthfile/pbvalue);
            }

            //while ((by = fs.ReadByte()) != -1)
            //{
            //    fswrite.WriteByte((byte)by);
            //}
            fs.Close();
            fswrite.Close();
        }
    }
}