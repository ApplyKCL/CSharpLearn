using System;

namespace C6T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number to Check if it is prime number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == 0 || num == 1)
            {
                Console.WriteLine("Number is not prime");
                return;
            }
            
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("Number is not prime");
                    return;
                }
            }
            Console.WriteLine("Number is prime");
        }
    }
}