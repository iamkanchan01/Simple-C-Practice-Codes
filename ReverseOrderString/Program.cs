using System;

namespace ReverseOrderString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, reverse ="";
            int length;

            Console.Write("Enter a word : ");
            str = Console.ReadLine();

            length = str.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }

            Console.WriteLine("Reverse string is {0}", reverse);


            
            
        }
    }
}
