using System;

namespace factorialNo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Factorial Number :");
            int factNo= Int32.Parse( Console.ReadLine());

            int factResult = 1;
            for(int i=1; i<factNo; i++)
            {
                factResult = factResult * i;
            }
            Console.WriteLine("{0}! is {1}", factNo, factResult);

        }
    }
}
