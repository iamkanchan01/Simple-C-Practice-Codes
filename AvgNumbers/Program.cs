using System;

namespace AvgNumbers
{
    class Program
    {
        static void Main()
        {
            int a, b, c, d;
            double avg;

            Console.Write("Enter 1st no : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd no : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd no : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 4th no : ");
            d = Convert.ToInt32(Console.ReadLine());

            avg = (a + b + c + d) / 4;
            Console.WriteLine("Average is : " + avg);


        }
    }
}
