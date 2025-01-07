using System;

namespace C6T1
{
    class Program
    {
        static void Main()
        {
            string[,] studentDirectory = new string[5, 2]
            {
                {"John", "52"},
                {"Jane", "60"},
                {"Joe", "100"},
                {"Jill", "80"},
                {"Jack", "90"}
            };

            for (int i = 0; i < studentDirectory.GetLength(0); i++)
            {
                if( int.Parse(studentDirectory[i, 1]) == 100)
                {
                    Console.WriteLine("{0}:\tA+", studentDirectory[i, 0]);
                }
                else if( int.Parse(studentDirectory[i, 1]) >= 90)
                {
                    Console.WriteLine("{0}:\tA", studentDirectory[i, 0]);
                }
                else if( int.Parse(studentDirectory[i, 1]) >= 80)
                {
                    Console.WriteLine("{0}:\tB", studentDirectory[i, 0]);
                }
                else if( int.Parse(studentDirectory[i, 1]) >= 70)
                {
                    Console.WriteLine("{0}:\tC", studentDirectory[i, 0]);
                }
                else if( int.Parse(studentDirectory[i, 1]) >= 60)
                {
                    Console.WriteLine("{0}:\tD", studentDirectory[i, 0]);
                }
                else
                {
                    Console.WriteLine("{0}:\tF", studentDirectory[i, 0]);
                }
            }
        }
    }
}