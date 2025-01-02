using System;
namespace C3P2
{
    class Program
    {
        static void Main()
        {
            string srch = "";
            string input = "";
            while (input != "END")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter the Search String: ");
                input = Console.ReadLine();
                if(!srch.Contains(input)){
                    srch += input + " ";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(srch);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("==================================");
                }
                
            }
        }
    }
}