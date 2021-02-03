namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            float celcius = 24;
            float celciusToWrong = (celcius / 5.0f) * 9.0f + 32.0f;

            System.Console.WriteLine(celcius + " Celsius is " + celciusToWrong + " Fahrenheit");

            float wrongToCelcius = (celciusToWrong - 32) * 5.0f / 9.0f;
            System.Console.WriteLine(celciusToWrong + " Fahrenheit is " + wrongToCelcius + " Celsius");
        }
    }
}