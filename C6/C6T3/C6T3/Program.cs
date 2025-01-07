using System;

namespace C6T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the Expected N");
            n = Convert.ToInt32(Console.ReadLine());
            int reuslt = 1;
            int previous = 0;
            while (n-1 > 0)
            {
                Console.WriteLine(reuslt);
                reuslt += previous;
                previous = reuslt - previous;
                n--;
            }
            Console.WriteLine(reuslt);
        }
    }
}