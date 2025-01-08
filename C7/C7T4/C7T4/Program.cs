using System;

namespace C7T4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] info =
            {
                {"Yam", "1", "68.9"},
                {"Potato", "2", "34.5"},
                {"Tomato", "3", "45.6"},
                {"Onion", "4", "23.4"},
                {"Carrot", "5", "67.8"}
            };
            Print(info);
        }
        
        static void Print(string[,] info)
        {
            
            for (int i = 0; i < info.GetLength(0); i++)
            {
                string element = "";
                for (int j = 0; j < info.GetLength(1); j++)
                {
                    element =element + info[i, j] + "\t";
                }
                Console.WriteLine(element);
                Console.WriteLine();
            }
        }
    }
}