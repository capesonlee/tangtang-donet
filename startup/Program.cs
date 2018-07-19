using System;

namespace startup
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }

            Console.WriteLine("Fibonacci Numbers 1-15:");

            Tangtang tang = new Tangtang("lixiyan");
            tang = null;
       
            Console.WriteLine("hello John");
        }
        static int FibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;
            for( int i = 0;i <n; i++)
            {
                tmp = a;
                a = b;
                b += tmp;
            }
            return a;
        }
    }
}
