using System;

namespace C4P3
{
    class Program
    {
        static void Main()
        {
            int totalWalkKm = 80500;
            double yearlyWalkKm = 80500 / 70.0;
            double dailyWalkKm = yearlyWalkKm / 70.0/ 365.0;
            
            Console.WriteLine("Total Yearly Walk: {0:F2} km", yearlyWalkKm);
            Console.WriteLine("Daily Walk: {0:F2} km", dailyWalkKm);
        }
    }
}