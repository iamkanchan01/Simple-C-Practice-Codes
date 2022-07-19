using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rem, result=0;
            Console.WriteLine("Enter a Value : ");
            num = Int32.Parse(Console.ReadLine());

            while (num != 0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num = num / 10;

            }
            Console.WriteLine("Result is : " + result);




        }
    }
}
