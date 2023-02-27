namespace Factorial_async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(6).ToString());
            Thread thread = new Thread(new ParameterizedThreadStart(FactorialAsync));
            thread.Start(6);
            //threads
            Thread threadStepan = new Thread(new ParameterizedThreadStart(StepanAsync));
            threadStepan.Start(new MyPow(2,8));

        }
        static void FactorialAsync(object obj)
        {
            //потоковый метод
            obj = Factorial((int)obj);
            Console.WriteLine(((int)obj).ToString());
        }
        static void StepanAsync(object obj)
        {
            //потоковый метод
           MyPow pow = (MyPow)obj;
            Console.WriteLine(pow.Getresult().ToString());
        }
        static int Factorial(int n)
        {
            int res = 1;
            for(int i = n; i>0;i-- )
            {
                res *= i;   
            }
            return res;
        }
        class MyPow
        {
            int Number;
            int Multipler;
            public MyPow(int number, int multipler)
            {
                Number = number;
                Multipler = multipler;
            }
            public int Getresult()
            {
                int result = 1;
                for(int i = 0; i < Multipler;i++)
                {
                    result *= Number;
                }
                return result;
            }
        }

    }
}