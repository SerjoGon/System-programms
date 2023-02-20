namespace AsyncWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(Sum);
            //ThreadPool.SetMaxThreads(2, 1);
            for(int i = 1; i < 20; i++) 
            {
            ThreadPool.QueueUserWorkItem(callback,i*10000);
            }
            //Console.WriteLine("Hell yeah!!!");
            Console.ReadLine();
        }
        static void Sum(object count)
        {
            double result = 0;
            for (int i = 0; i < (int)count; i++)
            {
                result += i;
            }
            //Console.WriteLine("Thread count "+ThreadPool.ThreadCount);
            Console.WriteLine("Thread number "+Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(result);
        }
    }
}