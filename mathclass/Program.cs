namespace mathclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to round off
            Console.WriteLine("it will give next full number "+ Math.Ceiling(15.3));
            Console.WriteLine("it will give last lower number " + Math.Floor(15.8));

            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("the first num is {0} and second num is {1}" , num1,num2);
            Console.WriteLine("the lower number from this 2 num are " + Math.Min(num1, num2));
            Console.WriteLine("the higher number from this 2 num are " + Math.Max(num1,num2));
        }
    }
}
