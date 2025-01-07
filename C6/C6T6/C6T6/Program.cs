using System;

namespace C6T6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter How Many Money You Have: ");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("How Many Chicken You Want To Buy: ");
            int chicken = int.Parse(Console.ReadLine());
            const int MchickenPrice = 5;
            const int FchickenPrice = 3;
            const int chickForThree = 1;
            for (int i = 0; i <= money / MchickenPrice; i++)
            {
                for (int j = 0; j <= money / FchickenPrice; j++)
                {
                    for (int k = 0; k <= money / chickForThree; k++)
                    {
                        if (i * MchickenPrice + j * FchickenPrice + k * chickForThree == money &&
                            (i + j + k * 3 == chicken))
                        {
                            Console.WriteLine("You Can Buy Male Chicken: " + i);
                            Console.WriteLine("You Can Buy Famle Chicken: " + j);
                            Console.WriteLine("You Can Buy Chicken For Three: " + k*3);
                        }
                    }
                }
            }
        }
    }
}