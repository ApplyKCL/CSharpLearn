using System;

namespace C6P3
{
    class Program
    {
        static void Main()
        { 
            Console.WriteLine("Define the Max Length of the Title that you want to display: ");
            int maxLength = Convert.ToInt32(Console.ReadLine());
            string title = "Please Enter a Title";
            while (!title.Equals("END"))
            {
                Console.WriteLine("Enter a Title: ");
                title = Console.ReadLine();
                if (title.Length > maxLength)
                {
                    title = title.Substring(0, maxLength);
                    Console.WriteLine(title + "...");
                }
                else
                {
                    Console.WriteLine(title);
                }
            }

        }
    }
}