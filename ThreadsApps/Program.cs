using System.Security;

namespace ThreadsApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MyObject myObject = new MyObject(Int32.Parse(Console.ReadLine()));
            myObject.start = Int32.Parse(Console.ReadLine());
            myObject.finish = Int32.Parse(Console.ReadLine());
            ParameterizedThreadStart parastart = new ParameterizedThreadStart(ConsoleWrite);
            for (int i = 0; i < myObject.threads.Length; i++)
            {
                myObject.threads[i] = new Thread(parastart);
            }
            for (int i = 0; i < myObject.threads.Length; i++)
            {
                myObject.threads[i].Start(myObject);
                myObject.threads[i].Join();

            }*/
            Random rand = new Random();
            int[] massive = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                massive[i] = rand.Next(15000);
            }
            ParameterizedThreadStart parastart = new ParameterizedThreadStart(TaskDelegate);
            Thread allThreads = new Thread(parastart);
            allThreads.Start(massive);
            allThreads.Join();
            /*for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine("From this prog: " + i);
            }*/
        }
        static void ConsoleWrite(object my)
        {
            int? start = ((MyObject)my).start;
            int? finish = ((MyObject)my).finish;
            string message = ((MyObject)my).message;
            for (int? i = start; i <= finish; i++)
            {
                Console.WriteLine("From this thread: " + i);
            }
            Console.WriteLine(message);

        }
        static void TaskDelegate(object massive)
        {
            ParameterizedThreadStart maxelemstart = new ParameterizedThreadStart(MaxElem);
            ParameterizedThreadStart minelemstart = new ParameterizedThreadStart(MinElem);
            ParameterizedThreadStart avgelemstart = new ParameterizedThreadStart(AvgElem);
            Thread thread1 = new Thread(maxelemstart);
            Thread thread2 = new Thread(minelemstart);
            Thread thread3 = new Thread(avgelemstart);
            thread1.Start(massive);
            thread2.Start(massive);
            thread3.Start(massive);
        }
        static void MaxElem(object massive)
        {
           
            Console.WriteLine(((int[])massive).Max().ToString());
        }
        static void MinElem(object massive)
        {
            Console.WriteLine(((int[])massive).Min().ToString());
        }
        static void AvgElem(object massive)
        {
            Console.WriteLine(((int[])massive).Average().ToString());
        }
        public class MyObject
        {
            public int? start { get; set; }
            public int? finish { get; set; }
            public string message { get; set; } = "это читерство";
            public Thread[] threads;
            MyObject() { }

            public MyObject(int countthread)
            {
                if (countthread > 0)
                {
                    threads = new Thread[countthread];
                }
                else
                {
                    threads = new Thread[1];
                }
            }
        }
    }
}