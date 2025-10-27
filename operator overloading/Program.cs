using System.ComponentModel;

namespace operator_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            box b1 = new box(1 , 2);
            box b2 = new box(3 , 4);
            box b3 = b1 + b2;
            Console.WriteLine(b3);

            box b4 = new box("blue");
            box b5 = new box("red");

            b4.details();
            b5.details();
        }


    }
}
