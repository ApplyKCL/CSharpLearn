using System;

namespace C5T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tYour Insurance Info");
            Console.WriteLine("Your Insurance Number: 123456789");
            Console.WriteLine("Your Insurance Name: John Doe");
            Console.WriteLine("Your Insurance Address: 1234 Elm St.");
            Console.WriteLine("Please Enter Your Gender: ");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your Gender: {0}", gender);
        }
    }
}