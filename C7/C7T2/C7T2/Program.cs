using System;

namespace C7T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] cards =  GenerateCards();
            Random random = new Random();
            int handCardCount = 0;
            while (handCardCount < 52)
            {
                int card = random.Next(0, 13);
                if (cards[card] > 0)
                {
                    cards[card]--;
                    handCardCount++;
                    Console.WriteLine("You got a card {0}: remind {1}", card, cards[card]);
                }
            }

        }
        static int [] GenerateCards()
        {
            int [] cards = new int[13];
            for(int i = 0; i < cards.Length; i++)
            {
                cards[i] = 4;
            }
            return cards;
        }
    }
}

