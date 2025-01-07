using System;

namespace C5P1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a sentence that u want to reverse: ");
            string name = Console.ReadLine();
            
            for(int i=name.Length-1; i>=0; i--)
            {
                Console.WriteLine(name[i]);
            }
            
        }
    }
}