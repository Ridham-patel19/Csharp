using System;

Console.WriteLine("please eneter the first number");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("please eneter the Second number");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("please eneter the operation which you have to perform (+,-,*,/)");
string oprand = Console.ReadLine();

if (oprand == "+")
{
    Console.WriteLine(a + b);
}
else if (oprand == "-")
{
    Console.WriteLine(a - b);
}
else if (oprand == "*")
{
    Console.WriteLine(a * b);
}
else if (oprand == "/")
{
    if (b == 0)
    {
        Console.WriteLine("you cannot devide any number with zero");
    }
    else
    {
        Console.WriteLine(a / b);
    }

}
else
{
    Console.WriteLine("eneter the valide number");
}
            
        