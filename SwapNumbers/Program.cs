using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main()
        {
            // Using Third Variable
            int Num1 = 10, Num2 = 5, Temp;

            Temp = Num1;
            Num1 = Num2;
            Num2 = Temp;
            Console.WriteLine("After Swaping Num1 is : " + Num1);
            Console.WriteLine("After Swaping Num2 is : " + Num2);

            //without Using Third variable + & -

            int a = 6, b = 7;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swaping Num1 is : " + a);
            Console.WriteLine("After Swaping Num1 is : " + b);

            //without Using Third variable *  & /

            int x = 6, y = 7;

            x = x * y;
            y = x / y;
            x = x / y;
            Console.WriteLine("After Swaping Num1 is : " + x);
            Console.WriteLine("After Swaping Num1 is : " + y);





        }
    }
}
