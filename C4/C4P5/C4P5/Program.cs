using System;

namespace C4P5
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int fieldOne = rand.Next(0, 10);
            int fieldTwo = rand.Next(0, 10);
            int token = rand.Next(0, 10);
            int answer = 0;
            Console.WriteLine("Please Enter the Correct Ans for the following Equation: ");
            if((token & 1) == 0)
            {
                Console.WriteLine(fieldOne + " + " + fieldTwo + " = ?");
                answer = fieldOne + fieldTwo;
            }
            else
            {
                Console.WriteLine(fieldOne + " * " + fieldTwo + " = ?");
                answer = fieldOne * fieldTwo;
            }
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            if(userAnswer == answer)
            {
                Console.WriteLine("Correct Ans");
            }
            else
            {
                Console.WriteLine("Incorrect Ans");
            }
        }
        
    }
}