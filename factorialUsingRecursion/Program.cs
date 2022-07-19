using System;

namespace factorialUsingRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fcatorial No : ");
            int factNo =Int32.Parse(Console.ReadLine());
            int result = FactorialCalc(factNo);
            Console.WriteLine(" Result is : {0}", result);


        }
        static int fact = 1;
        private static int FactorialCalc(int factNo)
        {
            
            if (factNo > 0)
            {
                fact = factNo * FactorialCalc(factNo - 1);
            }
            return fact;
        }
    }
}
