
//here we are using random class and creating instance of it 
Random random = new Random();

//its a method in this class we have to give 2 argument which give us num between 1<=num<11 so last num 11 not included
int randomNumber = random.Next(1, 11);




//lets make a game guess the num 

Console.WriteLine("please eneter num between 1 to 10");
string str = Console.ReadLine();
int num;

bool result = int.TryParse(str, out num);

if (result)
{
    if(num == randomNumber)
    {
        Console.WriteLine("congratulation you have guessed the number");

    }
    else
    {
        Console.WriteLine("sorry ! please try again");
    }
}
else
{
    Console.WriteLine("please eneter a number");
}
