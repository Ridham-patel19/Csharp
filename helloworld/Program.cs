// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, i am ridham");
Console.WriteLine("helo from ridham");

//declaring a string variable

string name;

//assinging  a value to a variable
name = "ridham";

//printing it to console
Console.WriteLine(name);


int num1;
Console.WriteLine("enter a num");

string inputstr = Console.ReadLine();

/*so this is a method wich will return true if guven string can converted in int 
 * in this we have to guve 2 arguments 1st is string which is going to be converted
 *  and second where we have to store result */
bool result = int.TryParse(inputstr, out num1);

if (result)
{
    //if result true so string is covertable in to int
    Console.WriteLine(num1);
}
else
{
    //if result false so guven input is string thaat cannot be converted into int
    Console.WriteLine("please eneter a number");
}
