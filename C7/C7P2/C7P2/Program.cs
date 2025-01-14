using System;
using System.Collections;
using System.Diagnostics;

namespace C7P2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a String");
            string input = Console.ReadLine();
            char [] charArry = input.ToCharArray();
            
            ArrayList list = new ArrayList(charArry);
            foreach (char word in list)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(list.Count);
            
        }
    }
}