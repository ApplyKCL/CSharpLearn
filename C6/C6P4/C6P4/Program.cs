using System;

namespace C6P4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Lottery Number: ");
            int [] lottery = new int[3];
            int index = 0;
            while (index < 3)
            {
                Console.WriteLine("Enter Number {0} in format ###: ", index + 1);
                string temp = Console.ReadLine();
                if(temp.Length > 3)
                {
                    Console.WriteLine("Invalid Input. Please Enter a 3 digit number.");
                    continue;
                }
                lottery[index] = int.Parse(temp);
                index++;
            }
            Console.WriteLine("Your Lottery Number is:\t{0}\t{1}\t{2}", lottery[0], lottery[1], lottery[2]);
            
            Random rand = new Random();
            int [] winning = new int[3];
            for (int i = 0; i < 3; i++)
            {
                winning[i] = rand.Next(0, 999);
            }
            
            Console.WriteLine("The Winning Number is:\t{0}\t{1}\t{2}", winning[0], winning[1], winning[2]);
            int winningCount = 0;
            for(int i = 0; i < 3; i++)
            {
                if(lottery[i] != winning[i])
                {
                    Console.WriteLine("Your Lottery Number did not match {0} Winning Number.", i);
                }
                else
                {
                    Console.WriteLine("Your Lottery Number matched {0} Winning Number.", i);
                    winningCount++;
                }
            }
            if(winningCount == 3)
            {
                Console.WriteLine("Congratulations! You have won the Lottery.");
            }
            else
            {
                Console.WriteLine("Sorry! You did not win the Lottery.");
            }
        }
    }
}

