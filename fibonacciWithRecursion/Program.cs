using System;

namespace fibonacciWithRecursion
{
    class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            //using recursion  method
            Console.Write("Enter input value : ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write(p1 + " " + p2);
            Fiboacci(count - 2);
        }

        private static void Fiboacci(int count)
        {
            if (count > 0)
            {
                p3 = p1 + p2;
                Console.Write(" " + p3);
                p1 = p2;
                p2 = p3;
                Fiboacci(count - 1);

            }
            
        }
    }
}
