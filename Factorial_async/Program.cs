namespace Factorial_async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(6));
        }
        static int Factorial(int n)
        {
            int res = 1;
            for(int i = n; n>0;i-- )
            {
                res *= i;   
            }
            return res;
        }

    }
}