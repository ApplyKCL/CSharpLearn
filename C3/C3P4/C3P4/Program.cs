using System;

namespace C3P4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double shouldPay = 100.00;
            double actualPay = 0;
            
            Console.WriteLine("You should Pay: " + shouldPay);
            Console.WriteLine("Please input the actual pay: ");
            actualPay = Convert.ToDouble(Console.ReadLine());
            if (actualPay > shouldPay)
            {
                Console.WriteLine("You should pay: " + shouldPay);
                Console.WriteLine("You actually pay: " + actualPay);
                Console.WriteLine("The change is: " + (actualPay - shouldPay));
            }
            else if(actualPay<shouldPay)
            {
                Console.WriteLine("You should pay: " + shouldPay);
                Console.WriteLine("You actually pay: " + actualPay);
                Console.WriteLine("You still need to pay: " + (shouldPay - actualPay));
            }
            else
            {
                Console.WriteLine("You pay the right amount");
            }
            DateTime dt = DateTime.Now;
            Console.WriteLine("Purchase Time\t" + dt);
        }
    }
}

