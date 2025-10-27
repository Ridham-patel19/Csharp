//initializing a varible
int number;

//assigning a value to a variable
number = 10;

//using $ means we can guve dynamic value
Console.WriteLine($"your number is {number}");

//overrriding a variable
number = 20;

Console.WriteLine($"your number is {number}");


int myNumber = 0;

//it will give erroe cuz we have declared variable as a int but readline() fun will return us string here 

//myNumber = Console.ReadLine();

Console.WriteLine("Enter a While number");

//it ill convert string in int but we have to guve prper number here like int nit a string or float etc other wise it will guve us an error
myNumber = int.Parse(Console.ReadLine());

Console.WriteLine(myNumber);