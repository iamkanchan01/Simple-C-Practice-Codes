using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, flag = 0;
            Console.Write("Enter a Number : ");
            n = Int32.Parse(Console.ReadLine());

            
            for(int i= 2; i<n; i++)
            {
                if (n%i ==0)
                {
                    Console.WriteLine("{0} is not prime number", n);
                    flag = 1;
                    break;

                }

            }
            if (flag==0)
            {
                Console.WriteLine("{0} is prime number");

            }
            
        }
    }
}
