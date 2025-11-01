namespace throws;

internal class Program
{
    static void Main(string[] args)
    {

        string num = "xkshckwhdci";
        bool result = int.TryParse(num, out int value);

        Console.WriteLine(result);

        isage(Console.ReadLine());
    }

    /* so some time you have to throw an error by ur self to stop the app from being 
     crash that is why we need this throw key word*/
    static void isage(string input)
    {
        if (!int.TryParse(input, out int value))
        {
            throw new Exception("you have to enter a number");
        }if (value < 0 || value > 120)
        {
            throw new Exception("please enetr a valid age");
        }
    }
}
