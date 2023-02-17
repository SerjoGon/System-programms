using System.Threading;

namespace WFwithAsyncThreads
{
    public partial class Form1 : Form
    {
        Thread[] threads = new Thread[3];
        char[] allchars = new char[]
        {
            'a','b','c','d', 'e', 'f', 'g', 'h', 'i',
            'j', 'k','l', 'm', 'n', 'o', 'p','q', 'r',
            's', 't', 'u','v', 'w', 'x', 'y', 'z',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
            '!', ',', '.', '?','&','@','#','$','^',':'
        };
        Random random = new Random();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbox_threads_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (Thread thread in threads)
                {
                    if (thread.Name != null)
                    {
                        if (thread.Name == lbox_threads.Items[lbox_threads.SelectedIndex].ToString())
                        {
                            comboBox1.SelectedIndex = (int)thread.Priority;
                        }
                    }
                }
            }
        }

        private void btn_numbthread_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(WriteNumbers);
            threads[0] = new Thread(start);
            //threads[0].Start();
            threads[0].Name = "Numbers Thread";
            lbox_threads.Items.Add(threads[0].Name.ToString());
        }

        private void btn_symbthread_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(writecharswrap);
            threads[1] = new Thread(start);
            threads[1].Name = "Symbols Thread";
            lbox_threads.Items.Add(threads[1].Name.ToString());
        }

        private void btn_letterthread_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(Writeletters);
            threads[2] = new Thread(start);
            threads[2].Name = "Letters Thread";
            lbox_threads.Items.Add(threads[2].Name.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbox_threads.SelectedIndex >= 0)
            {
                foreach (Thread thread in threads)
                {
                    if (thread.Name != null)
                    {
                        if (thread.Name == lbox_threads.Items[lbox_threads.SelectedIndex].ToString())
                        {
                            thread.Priority = (ThreadPriority)comboBox1.SelectedIndex;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            threads[0] = new Thread(new ThreadStart(Writeletters));
            threads[1] = new Thread(new ThreadStart(Writeletters));
            threads[2] = new Thread(new ThreadStart(Writeletters));
        }
        void writecharswrap()
        {
            richTextBox1.Invoke(WriteSymbols);
        }
        void WriteNumbers()
        {
            while (true)
            {
                richTextBox1.Text += allchars[random.Next(26, 35)];
                counter++;
                Thread.Sleep(50);
                if (counter > 1000)
                {
                    break;
                }
            }
        }
        void WriteSymbols()
        {
            while (true)
            {
                
                richTextBox1.Text += allchars[random.Next(36, 45)];
                counter++;
                Thread.Sleep(50);
                if (counter > 1000)
                {
                    break;
                }
            }
        }
        void Writeletters()
        {
            while (true)
            {
                richTextBox1.Text += allchars[random.Next(0, 25)];
                counter++;
                Thread.Sleep(50);
                if (counter > 1000)
                {
                    break;
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(lbox_threads.Items.Count > 0)
            {
                foreach (object obj in lbox_threads.Items)
                {
                    foreach(Thread thread in threads) 
                    {
                        if((string)(obj) == thread.Name)
                        { 
                            thread.Start(); 
                        } 
                    }
                }
            }
        }
    }
   
}