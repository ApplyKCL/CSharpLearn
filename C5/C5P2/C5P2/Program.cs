using System;

namespace C5P2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the String that you want to remove the Spaces from:");
            string input = Console.ReadLine();
            string [] words = input.Split(' ');
            string output = "";
            foreach (string word in words)
            {
                output += word;
            }
            Console.WriteLine("The String after removing the Spaces is: " + output);
        }
    }
}