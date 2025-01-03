using System;

namespace C4T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Purchase has been made?");
            int purchase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Amount of Chicken Food Been Made {0} g", purchase * 180);
        }
    }
}