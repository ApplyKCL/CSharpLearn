using System;
using System.Text;

namespace C5T6
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder strBld = new StringBuilder("Joe");
            strBld.Insert(0, "Hello ");
            Console.WriteLine(strBld);
        }
    }
}