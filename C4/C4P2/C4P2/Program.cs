using System;

namespace C4P2
{
    class Program
    {
        static void Main()
        {
            int x = 10;
            Console.WriteLine("Result = {0}",  10 + ++x);
            x = 10;
            Console.WriteLine("Result = {0}",  10 + x++);
        }
    }
}