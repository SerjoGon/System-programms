using System.Security;
using System.Text;
using System.Threading;

namespace ThreadsApps
{
    internal class Program
    {
        static ParameterizedThreadStart threadStart = new ParameterizedThreadStart(SaveDataToFile);
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
            thread1.Join();
            thread2.Start(massive);
            thread2.Join();
            thread3.Start(massive);
            thread3.Join();

        }
        static void MaxElem(object massive)
        {
            int result = ((int[])massive).Max();
            Console.WriteLine(result.ToString());
            Thread thread = new Thread(threadStart);
            thread.Start(result);
            thread.Join();
        }
        static void MinElem(object massive)
        {
            int result = ((int[])massive).Min();
            Console.WriteLine(result.ToString());
            Thread thread = new Thread(threadStart);
            thread.Start(result);
            thread.Join();
        }
        static void AvgElem(object massive)
        {
            double result = ((int[])massive).Average();
            Console.WriteLine(result.ToString());
            Thread thread = new Thread(threadStart);
            thread.Start(result);
            thread.Join();

        }
        static void SaveDataToFile(object number)
        {
            FileStreamOptions foptions = new FileStreamOptions();
            foptions.Access = FileAccess.Write;
            foptions.Share= FileShare.Write;
            foptions.Mode= FileMode.OpenOrCreate;
            
            //FileStream file = new FileStream("Task5.txt",FileMode.OpenOrCreate,FileAccess.Write,FileShare.Write);
            StreamWriter writer = new StreamWriter("Task5.txt",Encoding.UTF8, foptions);
            writer.WriteLineAsync(number.ToString());
            writer.Close();
        }
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