int age = 21;
string name = "Ridham";
int id = 1234;

//composite string formating 
Console.WriteLine("your name is {0} your age is {1} your id id {2}",name,age,id);

string s1 = "hello this is string woth slash / and a colon ;";
/*some charachter are pre build in c# for string like  "  if i have to use this in my string 
 * then i have to use the the escapre charater in it for eg '\' back slash */
string s2 = "he is \"ridham\"";

Console.WriteLine($"{s1}  {s2}");


Console.WriteLine("enter the age");
int userage = int.Parse(Console.ReadLine());
bool isValidDriver;


if (userage >= 18)
{
    Console.WriteLine("do  you know driving enter true or false");
    bool isDriving = bool.Parse(Console.ReadLine());
    Console.WriteLine("do you with any valid driver enter true or false");
    isValidDriver = bool.Parse(Console.ReadLine());



    if (isDriving)
    {
        Console.WriteLine("you are eligable");
    }
    else if(isDriving || isValidDriver)
    {
        Console.WriteLine("then you can drive with experirnce one");
    } else
    {
        Console.WriteLine("sorry you have to work on it");
    }
}
else
{
    Console.WriteLine("you are not eligable");
}
