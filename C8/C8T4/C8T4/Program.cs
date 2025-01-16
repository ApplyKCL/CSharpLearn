using System;
using System.Collections;

namespace C8T4
{
    class Program
    {
        class Numbers
        {
            private string[] numbers = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

            public string getNumber(string number)
            {
                foreach (string num in numbers)
                {
                    if (num == number)
                    {
                        return num;
                    }
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();
            for(int i = 0; i < number.Length; i++)
            {
                string num = numbers.getNumber(number[i].ToString());
                if (num == null)
                {
                    Console.WriteLine("Invalid number");
                    return;
                }else
                {
                    Console.WriteLine(num);
                }
            }
            
        }
        
    }
}