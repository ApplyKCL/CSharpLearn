using System;


namespace C6T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose The Flower You Like, the meaning of the flower will be displayed");
            Console.WriteLine("1. Rose");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Tulip");
            Console.WriteLine("4. Lily");
            Console.WriteLine("5. Orchid");
            Console.WriteLine("6. Daisy");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case '1':
                    Console.WriteLine("Rose: Love, Beauty, Courage and Respect");
                    break;
                case '2':
                    Console.WriteLine("Sunflower: Adoration, Loyalty and Longevity");
                    break;
                case '3':
                    Console.WriteLine("Tulip: Perfect Love, Fame and Charity");
                    break;
                case '4':
                    Console.WriteLine("Lily: Purity and refined beauty");
                    break;
                case '5':
                    Console.WriteLine("Orchid: Love, Beauty, Refinement, Beautiful Lady, Chinese Symbol for Many Children");
                    break;
                case '6':
                    Console.WriteLine("Daisy: Innocence, Loyal Love, I'll Never Tell, Purity");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            
        }
    }
}