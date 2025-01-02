using System;

namespace C3P3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter The Product Serial Number: ");
            string serialNumber = Console.ReadLine();
            Console.Write("Enter The Product Name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter The product Scale: ");
            string productScale = Console.ReadLine();
            Console.Write("Enter The Product Price: ");
            string productPrice = Console.ReadLine();
            Console.Write("Enter The Product Quantity: ");
            string productQuantity = Console.ReadLine();
            
            Console.WriteLine("Product Serial Number: {0}", serialNumber);
            Console.WriteLine("Product Name: {0}", productName);
            Console.WriteLine("Product Scale: {0}", productScale);
            Console.WriteLine("Product Price: {0}", productPrice);
            Console.WriteLine("Product Quantity: {0}", productQuantity);
            
        }
    }
}