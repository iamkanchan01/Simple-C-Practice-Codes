using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, k;

            Console.Write("Enter a Number: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                k = n % 10;
                n = n / 10;
                sum = sum + k;
            }
            Console.WriteLine("Sum of Digits is : " + sum);
        }
    }
}
