Console.WriteLine("enter the first number ");

double myNum = double.Parse(Console.ReadLine());

Console.WriteLine("enter the Second number ");

double myNum2 = double.Parse(Console.ReadLine());

double sum = myNum + myNum2;

//here we are using string concatination
Console.WriteLine("your total sum is "+sum);

//here we are using string interpolation
Console.WriteLine($"your total sum is {sum} ");

//this is a explicite typed varible 
int a = 10;

//this is a implicitly type varicble here we are not telling proper 
var mystr = "ridham";
var mynum = 13;

/*this is implicite conversion we can do this cuz double can hold 
 all info about int but we cant do reverse like an int cant hold double */
double b = a;

//this is explicite conversion we are doing it manually but we have to take care like that this type can handle the given type
a = (int)b;

int x = 1;
//here we are using convert class
bool boolean = Convert.ToBoolean(x);

string str = "123";
int y = int.Parse(str);

