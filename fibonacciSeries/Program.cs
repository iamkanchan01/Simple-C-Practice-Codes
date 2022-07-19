using System;

namespace fibonacciSeries
{
    class Program
    {
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            //using iterative method
            Console.WriteLine("Enter input value : ");
            int count = Convert.ToInt32( Console.ReadLine());
            Console.Write(p1 + " " + p2);
            for(int i=2; i<count; i++)
            {
                p3 = p1 + p2;
                Console.Write( " " + p3);
                p1 = p2;
                p2 = p3;

            }
            Console.WriteLine();

        }
    }
}
