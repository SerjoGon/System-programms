using Microsoft.VisualBasic;

namespace DancingProgressBar
{
    public partial class Form1 : Form
    {
        //System.Threading.Timer timer; //task1
        System.Threading.Timer timer; //task1
        List<ResultRow> results = new();
        List<myTimer> timers = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region task1
            /*task1
            TimerCallback callback = new TimerCallback(CallBack);
            timer = new System.Threading.Timer(callback,this.Controls,0,1500);*/
            #endregion
            foreach (Control control in this.Controls)
            {
                if (control != null && control.GetType() == progressBar1.GetType())
                {
                    ProgressBar bar = (ProgressBar)control;
                    timers.Add(new myTimer(bar));
                }
            }
            foreach (myTimer timer in timers)
            {
                timer.StartTimer();
            }
            Thread thread = new Thread(
                new ThreadStart(
                    delegate ()
                    {
                        bool notend = true;
                        int counter = 0;
                        while (notend)
                        {

                            foreach (myTimer timer in timers)
                            {
                                if (timer.isRunning)
                                {
                                    counter++;
                                }
                            }
                            if (counter == 5)
                            {
                                notend = false;
                            }
                            else
                            {
                                counter = 0;
                            }
                            Thread.Sleep(200);
                        }
                        foreach (myTimer timer in timers)
                        {
                            results.Add(timer.GetResultRow());
                        }
                    }
                    )
                );
            thread.Start();
        }
        #region task1
        /*
    void CallBack(object collection)
    {
        foreach (Control control in this.Controls)
        {
            if (control != null && control.GetType() == progressBar1.GetType())
            {
                ProgressBar Bar = (ProgressBar)control;
                Bar.BeginInvoke(new Action(() =>
                {
                    Random rand = new Random();
                    Bar.Value = rand.Next(Bar.Minimum, Bar.Maximum);
                    Thread.Sleep(100);
                }));
            }
        }
        foreach (Control control in this.Controls)
        {
            if (control != null && control.GetType() == progressBar1.GetType())
            {
                ProgressBar Bar = (ProgressBar)control;
                Bar.BeginInvoke(new Action(() =>
                {
                    Random rand = new();
                    int step = rand.Next(0, 5);
                    if (Bar.Value + step > Bar.Maximum)
                    {
                        Bar.Value = Bar.Maximum;
                        results.Add(new ResultRow(Bar.Name, TimeSpan.Zero));
                    }
                    else
                    {
                        Bar.Value += step;
                    }
                    Bar.Value += rand.Next(Bar.Minimum, Bar.Maximum);
                    //Thread.Sleep(100);
                }));
            }
        }
    }
        */
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region task1
            /* foreach (Control control in this.Controls)
             {
                 if (control != null && control.GetType() == progressBar1.GetType())
                 {
                     ProgressBar bar = (ProgressBar)control;
                     bar.EndInvoke();
                 }
             }            */
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach(ResultRow result in results)
            {
                res += result.ToString() + "\n";
            }
            MessageBox.Show(res);
        }
    }
    class ResultRow
    {
        string BarName;
        TimeSpan _time;

        public ResultRow(string name, TimeSpan time)
        {
            BarName = name;
            _time = time;
        }
        public override string ToString()
        {
            return BarName + " " + _time.ToString();
        }
    }
    class myTimer
    {
        bool isRunning { get; set; }
        System.Threading.Timer timer;
        ProgressBar myprogress;
        DateTime mytime;
        TimeSpan mytSpan = TimeSpan.Zero;
        public myTimer(ProgressBar progress)
        {
            myprogress = progress;
        }
        public void StartTimer()
        {
            mytime = DateTime.Now;
            TimerCallback callback = new TimerCallback(this.CallBack);
            timer = new System.Threading.Timer(callback, myprogress, 0, 500);
        }
        void DelTimer()
        {
            mytSpan = DateTime.Now - mytime;
            timer.Dispose();
        }
        void CallBack(object obj)
        {
            ProgressBar Bar = (ProgressBar)obj;
            Bar.BeginInvoke(new Action(() =>
            {
                Random rand = new();
                int step = rand.Next(0, 5);
                if (Bar.Value + step > Bar.Maximum)
                {
                    Bar.Value = Bar.Maximum;
                    DelTimer();
                }
                else
                {
                    Bar.Value += step;
                }
                Bar.Value += rand.Next(Bar.Minimum, Bar.Maximum);
                //Thread.Sleep(100);
            }));
        }
        public ResultRow GetResultRow()
        {
            return new ResultRow(myprogress.Name, mytSpan);
        }
    }

}