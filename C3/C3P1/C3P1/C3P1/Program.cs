using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Home Address:");
            string home = Console.ReadLine();
            Console.Write("Enter Your Work Address:");
            string company = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n------Your Address Information------");
            Console.WriteLine("Home" + home);
            Console.WriteLine("Company" + company);
            Console.ReadLine();
        }
    }
} 