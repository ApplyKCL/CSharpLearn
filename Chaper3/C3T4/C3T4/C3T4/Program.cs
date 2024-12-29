using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace C3T4
{
    class Program
    {
        static void Main(string [] args)
        {
            string [] pass = new string [6];
            
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter password: ");
                pass[i] = Console.ReadLine();
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Password {0}: {1}", i + 1, pass[i]);
            }
        }
    }
}

// Text Book Answer
// namespace Demo
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string password = "";
//             Console.Write("Enter the Password：");
//             password += Console.ReadLine();
//             Console.Write("Enter the Password：");
//             password += "," + Console.ReadLine();
//             Console.Write("Enter the Password：");
//             password += "," + Console.ReadLine();
//             Console.Write("Enter the Password：");
//             password += "," + Console.ReadLine();
//             Console.Write("Enter the Password：");
//             password += "," + Console.ReadLine();
//             Console.Write("Enter the Password：");
//             password += "," + Console.ReadLine();
//             Console.Write("\n The Password Your Entered in 6 Times is: "+password);
//             Console.ReadLine();
//         }
//     }
// }