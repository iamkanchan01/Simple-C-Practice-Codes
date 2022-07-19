using System;

namespace PalidromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i, j, flag = 1;

            Console.Write("Enter a String: ");
            str = Console.ReadLine();

            for(i=0, j= str.Length-1; j!=0; i++, j--  )
            {
                if (str[i]==str[j])
                {

                }
                else
                {
                    flag = 0;
                    break;
                }

            }
            if (flag == 1)
            {
                Console.WriteLine("string is palidrome");
            }
            else
            {
                Console.WriteLine("string is not palidrome");

            }
        }
    }
}
