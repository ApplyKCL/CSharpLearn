using System;

namespace C5T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******Product List******");
            Console.WriteLine("1. Apple999X 1000\n2. Banana1000Pro 999.99\n3. Orange1500Ultra 1000.99");
            Console.WriteLine("*************************");
            Console.WriteLine("Enter the product number: ");
            int productNumber = Convert.ToInt32(Console.ReadLine());
            switch (productNumber)
            {
                case 1:
                    Console.WriteLine("You Purchased Apple999X, which costs {0:C0}", 1000);
                    break;
                case 2:
                    Console.WriteLine("You Purchased Banana1000Pro, which costs {0:C2}", 999.99);
                    break;
                case 3:
                    Console.WriteLine("You Purchased Orange1500Ultra, which costs {0:C2}", 1000.99);
                    break;
                default:
                    Console.WriteLine("Invalid product number");
                    break;
            }
        }
    }
}