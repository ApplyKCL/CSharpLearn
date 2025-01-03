using System;

namespace C3P5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Bags of Milks Do You Want?");
            int bags = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Total Protain is: {0:f1}", bags * 6.4);
        }

    }
}