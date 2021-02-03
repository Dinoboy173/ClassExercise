using System;
namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            int multiplier = 0;
            int number = 0;

            while (multiplier < 11)
            {
                while (number < 11)
                {
                    int answer = multiplier * number;
                    Console.WriteLine(number + " * " + multiplier + " = " + answer);
                    number = number + 1;
                }
                number = 0;
                multiplier = multiplier + 1;
            }
        }
    }
}
