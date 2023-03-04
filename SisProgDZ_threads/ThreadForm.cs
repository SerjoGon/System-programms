namespace SisProgDZ_threads
{
    public partial class ThreadsForm : Form
    {
        public ThreadsForm()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            PrimeFunc();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {

        }
        public void PrimeFunc()
        {
            richTextBox1.Text += "Простые числа в диапазоне от  "+tb_minvalue.Text+" до "+tb_maxvalue.Text;
            for(int i = Int32.Parse(tb_minvalue.Text); i < Int32.Parse(tb_maxvalue.Text);i++)
            {
                if(IsPrimeNumber(i))
                {
                    richTextBox1.Text += " \n"+i.ToString();
                }
            }
        }
        public static bool IsPrimeNumber(int n)
        {
            bool result = true;
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

    }

}