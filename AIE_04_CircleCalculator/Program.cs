using System;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            double radius = 10;
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);

            // TODO: Output
            Console.WriteLine("The circumference is " + circumference);
            Console.WriteLine("The area is " + area);
        }
    }
}