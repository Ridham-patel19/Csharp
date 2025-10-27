int count = 0;
Random random = new Random();
int randomnum = random.Next(1, 11);

bool isSame = false;

while (!isSame)
{
    Console.WriteLine("enter the number");
    int userChoice = int.Parse(Console.ReadLine());

    if(randomnum == userChoice)
    {
        Console.WriteLine("Congratulation! you have guessed the number your total chace " + count);
        isSame = true;
    }
    count++;
}
