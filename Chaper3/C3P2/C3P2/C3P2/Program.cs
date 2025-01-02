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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Python");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("============================================================== ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" Enter The Search Words:");
            string words = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Python  " + words);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ============================================================== ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" Enter The Search Words:");
            Console.ReadLine();//定位控制台窗体
        }
    }
}