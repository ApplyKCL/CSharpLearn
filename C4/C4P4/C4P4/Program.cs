using System;

namespace C4P4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("How Many Energy Do you Have?");
            int energy = int.Parse(Console.ReadLine());
            Console.WriteLine("The Total Award Amount is {0}", energy/100);
        }
    }
}