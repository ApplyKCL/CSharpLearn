using System;

namespace C6P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Gas Type: \n1. Diesel\n2. Petrol\n3. CNG");
            string gasType = Console.ReadLine();
            Console.WriteLine("Please Enter the Amount of Gas: ");
            double gasAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the Service Type: \n1. Self Service\n2. Full Service");
            string serviceType = Console.ReadLine();
            double gasPrice = 0;
            switch (gasType)
            {
                case "1":
                    gasPrice = 6.8;
                    break;
                case "2":
                    gasPrice = 7.02;
                    break;
                case "3":
                    gasPrice = 5.75;
                    break;
                default:
                    Console.WriteLine("Invalid Gas Type");
                    break;
            }
            
            double totalPrice = gasPrice * gasAmount;
            if (serviceType == "1")
            {
                totalPrice *= 0.9;
            }
            
            Console.WriteLine("Total Price: " + totalPrice);
        }
    }
}