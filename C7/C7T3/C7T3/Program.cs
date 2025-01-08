using System;

namespace C7T3
{
    class Program
    {
        static void Main(string[] args)
        {
            char [,] poem = new char[4, 4] { {'T', 'w', 'a', 's'},
                                             {'b', 'r', 'i', 'l'},
                                             {'l', 'i', 'g', 'h'},
                                             {'t', 'n', 'i', 'g'} };
            PrintPoem(poem);
            Console.WriteLine();
            PrintPoemByRow(poem);
            
        }
        static void PrintPoem(char[,] poem)
        {
            for (int i = 0; i < poem.GetLength(0); i++)
            {
                for (int j = 0; j < poem.GetLength(1); j++)
                {
                    Console.Write(poem[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void PrintPoemByRow(char[,] poem)
        {
            for (int i = 0; i < poem.GetLength(1); i++)
            {
                for (int j = 0; j < poem.GetLength(0); j++)
                {
                    Console.Write(poem[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}