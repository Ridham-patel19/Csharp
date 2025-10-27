Console.WriteLine("entrer the number for the day name in a week  from 1 to 7");
int Weekday = int.Parse(Console.ReadLine());

switch (Weekday) {
    case 1:
        Console.WriteLine("monday");
        break;
    case 2:
        Console.WriteLine("tuesday");
        break;
    case 3:
        Console.WriteLine("wednesday");
        break;
    case 4:
        Console.WriteLine("thursday");
        break;
    case 5:
        Console.WriteLine("friday");
        break;
    case 6:
        Console.WriteLine("saturday");
        break;
    case 7:
        Console.WriteLine("sunday");
        break;
    default:
        Console.WriteLine("you have netered the wrong number");
        break;
}
