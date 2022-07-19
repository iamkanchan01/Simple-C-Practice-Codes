using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(23+87); // directly getting value

            // getting value from user
            int a, b;
            int sum;

            Console.Write("Enter 1st no : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2st no : ");
            b = Convert.ToInt32(Console.ReadLine());

            sum = a + b;

            Console.WriteLine("Total sum is : " + sum);



        }
    }
}
