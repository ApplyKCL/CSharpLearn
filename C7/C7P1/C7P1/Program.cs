using System;

namespace C7P1
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int n = 10;
            int [] arr = new int [n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
            }
            Console.WriteLine("Before sorting:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            arr = shellSort(arr);
            Console.WriteLine("After sorting:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
        }
        static int [] shellSort(int [] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }
                    arr[j] = temp;
                }
            }
            return arr;
        }
    }
}