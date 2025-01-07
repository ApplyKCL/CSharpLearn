using System;

namespace C6P1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This Program will calculate the result based on the following formula:");
            Console.WriteLine("b=3a (a<50)");
            Console.WriteLine("b=6a + 60 (50<=a<500)");
            Console.WriteLine("b=9a - 90 (a>=500)");
            Console.WriteLine("Please Enter the number a");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            if(a < 50)
            {
                b = 3 * a;
            }
            else if(a >= 50 && a < 500)
            {
                b = 6 * a + 60;
            }
            else
            {
                b = 9 * a - 90;
            }
            Console.WriteLine("The result is: " + b);
        }
    }
}