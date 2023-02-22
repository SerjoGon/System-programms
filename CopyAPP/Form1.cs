using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;

namespace CopyAPP
{
    public partial class Form1 : Form
    {
        byte[] data;
        long pbvalue = 1;
        long lengthfile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_origpath.Text = @"D:\text.txt";
            tb_targetpath.Text = @"D:\textcopy.txt";
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
            /*Обьявление переменных и потоков*/
            FileStream fs = new FileStream(tb_origpath.Text, FileMode.Open, FileAccess.Read, FileShare.Read, 100, FileOptions.Asynchronous);
            
            lengthfile = fs.Length;
            /*Установка нач знач прогресс бара*/
            progressBar1.Maximum = (int)lengthfile;
            progressBar1.Minimum = 0;
            /*Создание массива чтения файла */
            int countoperation = 1000;
            long[] partsfilelength = new long[countoperation];
            for (int i = 0; i < countoperation; i++)
            {
                partsfilelength[i] = fs.Length / countoperation;
                if (i == countoperation - 1)
                {
                    partsfilelength[i] += lengthfile % countoperation;
                }
            }
            /*Установка конеч знач прогресс бара*/
            if (lengthfile > countoperation)
            {
                pbvalue = lengthfile / countoperation;
            }
            for (int i = 0; i < countoperation; i++)
            {
                data = new byte[partsfilelength[i]];
                int pos = data.Length * i;
                fs.BeginRead(data, 0, data.Length, MessageBoxPrint, new MyStateObject(data,fs,tb_targetpath.Text,pos));
            }
            #region Old code
            /*
             * Плохой код
            IAsyncResult result;
            result = fs.BeginRead(b, 0, b.Length, null, null);
            foreach (long i in partsfilelength)
            {
                b = new byte[i];
                fs.BeginRead(b, 0, b.Length, null, null);
                fs.Read(b, 0, b.Length);
                fswrite.Write(b, 0, b.Length);
                progressBar1.Value = (int)(lengthfile/pbvalue);
            }*/

            //while ((by = fs.ReadByte()) != -1)
            //{
            //    fswrite.WriteByte((byte)by);
            //}
            #endregion 
            fs.Close();
        }
        void MessageBoxPrint(IAsyncResult assresult)
        {
            MyStateObject mystateobj = (MyStateObject)assresult.AsyncState;
            mystateobj.EndRead(assresult);
            mystateobj.Write();
           
        }
        class MyStateObject
        {
            byte[] _bytes;
            FileStream _filestream;
            FileStream _fswrite ;
            
            
            public MyStateObject(byte[] bytes, FileStream filestream,string path,int position)
            {
                _bytes = bytes;
                _filestream = filestream;
                _fswrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write, 100, FileOptions.Asynchronous);
                _filestream.Position = position;
            }
            public void EndRead(IAsyncResult assres)
            {
                _filestream.EndRead(assres);
            }
            public void Write()
            {
                _fswrite.BeginWrite(_bytes, 0, _bytes.Length, CloseWrite, _fswrite);
            }
            private void CloseWrite(IAsyncResult assres)
            {
                FileStream stream = (FileStream)assres.AsyncState;
                stream.EndWrite(assres);
                _fswrite.Close();
            }
        }
    }
}