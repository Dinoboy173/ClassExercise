namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter a number.");

            string sNumber = System.Console.ReadLine();
            int number = int.Parse(sNumber);

            if (number > 50)
            {
                System.Console.WriteLine("Bigger");
            }
            else
            {   
                System.Console.WriteLine("Smaller");
            }
            
        }
    }
}