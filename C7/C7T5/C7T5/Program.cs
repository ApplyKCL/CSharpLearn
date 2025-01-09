using System;

namespace C7T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int [3, 3];
            int a = 2;
            int b = 1;
            for (int i = 1; i <= 9; i++)
            {
                arr[a++, b++] = i;
                
                if (i % 3 == 0)
                {
                    a = a - 2;
                    b = b - 1;
                }
                else
                {
                    a = a % 3;
                    b = b % 3;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}