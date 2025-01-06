using System;

namespace C5T3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int index =  input.IndexOf("Dream");
            if (index == -1)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            
        }
    }
}