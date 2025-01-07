using System;


namespace C6T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Height of the Triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Elements of the Triangle: ");
            string element = Console.ReadLine();
            int heightIndex = 0;
            int widthIndex = 0;
            while (heightIndex < height)
            {
                for(int i = 0; i < height - heightIndex; i++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < heightIndex*2+1; j++)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
                heightIndex++;
            }
        }
    }
}