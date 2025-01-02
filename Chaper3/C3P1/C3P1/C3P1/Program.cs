using System;

namespace C3P1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Your Home Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Please Enter Your City:");
            string city = Console.ReadLine();
            Console.WriteLine("Please Enter Your State:");
            string state = Console.ReadLine();
            Console.WriteLine("Please Enter Your Zip Code:");
            string zip = Console.ReadLine();
            Console.WriteLine("Please Enter Your Country:");
            string country = Console.ReadLine();
            Console.WriteLine("Your Address is: \n" + address + "\n" + city + ", " + state + " " + zip + "\n" + country);
        }
    }
} 