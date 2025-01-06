using System;
using System.Text;

namespace C5T5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello, World!";
            StringBuilder strbld = new StringBuilder(str);
            Console.WriteLine(str);
            Console.WriteLine(strbld);
            
            
            Console.WriteLine(str.GetHashCode());
            str = str.Insert(0, "Hello, World!");
            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(strbld.GetHashCode());
            strbld.Insert(0, "Hello, World!");
            Console.WriteLine(strbld.GetHashCode());
        }
    }
}