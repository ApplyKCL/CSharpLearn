using System;
using System.Collections;

namespace C7T9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[]
            {
                "Ming", "Male", "1980-01-01", "Lee", "Female", "1981-01-01", "Mei", "Female", "1982-01-01"
            };
            ArrayList studentList = new ArrayList(students);
            int index = 0;
            foreach (string element in studentList)
            {
                if (index % 3 == 2)
                {
                    DateTime date = DateTime.Parse(element);
                    string dateStr = string.Format("{0:D}", date);
                    Console.WriteLine(dateStr);
                }
                else
                {
                    Console.Write(element + "\t");
                }
                
                index++;
            }

        }
    }
}