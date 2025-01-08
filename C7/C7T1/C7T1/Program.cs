using System;

namespace C7T1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentGrades = { 80, 90, 99, 60, 70 };
            foreach (int studentGrade in studentGrades)
            {
                Console.WriteLine(studentGrade);
            }
            
        }
    }
}