namespace SisProgDZ_threads
{
    public partial class ThreadsForm : Form
    {
        ThreadStart primefuncThread;
        Thread primeThread;
        static bool threadStoper;
        public ThreadsForm()
        {
            InitializeComponent();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            //Threadstarter("Start");
            threadStoper = true;
            Threadstarter();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //Threadstarter("Stop");
            threadStoper = false;
        }
        void Threadstarter()
        {

            primefuncThread = new ThreadStart(PrimeFunc);
            primeThread = new Thread(PrimeFunc);
            /*if (str == "Start")
            {
                primeThread.Start();
            }
            else
            {
                primeThread.Suspend();
            }*/
            if (threadStoper == true)
            {
                primeThread.Start();
            }
            else
            {
                primeThread.Suspend();
            }

        }
        public void PrimeFunc()
        {
            richTextBox1.Text += "Простые числа в диапазоне от  " + tb_minvalue.Text + " до " + tb_maxvalue.Text;
            for (int i = Int32.Parse(tb_minvalue.Text); i < Int32.Parse(tb_maxvalue.Text); i++)
            {
                if (IsPrimeNumber(i))
                {
                    richTextBox1.Text += " \n" + i.ToString();
                    Thread.Sleep(1000);
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

        private void btn_startFibthread_Click(object sender, EventArgs e)
        {
            ThreadFunction("Start");
        }
        private void btn_stopFibthread_Click(object sender, EventArgs e)
        {
            ThreadFunction("Stop");
        }
        void ThreadFunction(string str)
        {
            ThreadStart fibonF = new ThreadStart(FibFunc);
            Thread threadFib = new Thread(FibFunc);
            if (str == "Start")
            {
                threadFib.Start();
            }
            else
            {
                threadFib.Interrupt();
            }
        }
        void FibFunc()
        {
            Fibonachi(tb_FibonRange.Text);
        }
        void Fibonachi(string numb)
        {
            int n = Int32.Parse(numb);
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
                rtb_FibonNumbers.Text += result + "\n";
                Thread.Sleep(2000);
            }
        }

    }

}