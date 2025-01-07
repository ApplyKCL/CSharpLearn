using System;

namespace C6T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guess = random.Next(1, 200);
            int input = 0;
            do
            {
                Console.WriteLine("Guess a number between 1 and 200");
                input = int.Parse(Console.ReadLine());
                if (input > guess)
                {
                    Console.WriteLine("Too high");
                }
                else if (input < guess)
                {
                    Console.WriteLine("Too low");
                }
                else
                {
                    Console.WriteLine("Correct");
                }
            }while(input != guess);
        }
    }
};

