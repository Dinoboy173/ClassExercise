namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            int currentYear = 2021;
            int birthYear = 2002;
            int age = currentYear - birthYear;
            
            System.Console.WriteLine($"You are {age} years old.");
        }
    }
}