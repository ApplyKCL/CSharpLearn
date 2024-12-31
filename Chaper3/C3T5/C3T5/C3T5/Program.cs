using System;


namespace C3T5
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = 0f;
            const float PI = 3.14159f;
            float area = 0f;
            Console.WriteLine("Enter the radius of the circle: ");
            radius = float.Parse(Console.ReadLine());
            area = PI * radius * radius;
            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}