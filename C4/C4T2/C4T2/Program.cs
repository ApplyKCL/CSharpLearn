using System;

namespace C4T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double feePerKiloMeter = 2.6;
            float gasFee = 3.0f;
            double distance = 0;
            double kiloMeter = 0;
            double totalFee = 0;
            double startFee = 10;
            Console.WriteLine("Enter the distance in kilometers: ");
            distance = Convert.ToDouble(Console.ReadLine());
            if (distance <= 2)
            {
                totalFee = startFee;
                Console.WriteLine("The total fee is: " + totalFee);
            }
            else
            {
                kiloMeter = distance - 2;
                totalFee = startFee + (kiloMeter-2 )* feePerKiloMeter;
                Console.WriteLine("The total fee is: " + totalFee);
                if(totalFee - Math.Floor(totalFee) >= 0.5)
                {
                    totalFee = Math.Ceiling(totalFee);
                }
                else
                {
                    totalFee = Math.Floor(totalFee);
                }
            }
            
            Console.WriteLine("The actual charge is: " + totalFee);
        }
    }
}