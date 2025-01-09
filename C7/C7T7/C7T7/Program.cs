using System;

namespace C7T7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            numbers = PopSort(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        static int [] PopSort(int [] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if(numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}