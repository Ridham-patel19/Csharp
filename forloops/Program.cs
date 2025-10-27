int a = 0;
//here "\" is an escape character \n stance for new line
//string str = "hi \nhi";
string str = "  |\r\n / \\\r\n*---*\r\n| o |\r\n| o |\r\n*---*\r\n / _\\";


for (int i = 5; i >= 1; i--)
{
    
    
    
    Console.WriteLine(i);
    
    Console.WriteLine(str);
    str = "\n" + str;
    Thread.Sleep(1000);
    Console.Clear();
}

Console.WriteLine("your rocket landed sucessfully!");


int count = 15;

//this loop will exicuted atleast 1 time doesnt matter that condition is match or not 
do
{
    Console.WriteLine(count);
    count++;
}while(count < 10);