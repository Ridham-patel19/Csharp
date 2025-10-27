

//declaring an array 
//this is how you declare array in c# with new key word here i am guving a size of a 5 to this array
int[] MyArray = new int[5];

//assigning a value to a this array
MyArray[0] = 1;
MyArray[1] = 2;
MyArray[2] = 3;
MyArray[3] = 4;
MyArray[4] = 5;

//printing its value
Console.WriteLine(MyArray[0]);

//lenghth fun will give us length of an array
Console.WriteLine(MyArray.Length);


for(int i = 0; i<=MyArray.Length-1; i++)
{
    Console.WriteLine($"this is index {i} and this is the value of it {MyArray[i]}");
}


Console.WriteLine();
Console.WriteLine("here is the for each loop value");
//here is for each loop 
foreach(int i in MyArray)
{
    Console.WriteLine(i);
}



Console.WriteLine();
Console.WriteLine("this the second array \n");


//here we are declaring and assigning value directly to an array
int[] MySecondArray = [11, 22, 33, 44, 55];

for (int i = 0; i <= MySecondArray.Length - 1; i++)
{
    Console.WriteLine($"this is index {i} and this is the value of it {MySecondArray[i]}");
}



Console.WriteLine();

string[] WeekDay = ["mon", "tue", "wed", "thu", "fri", "sat", "sun"];

for (int i = 0; i <= WeekDay.Length - 1; i++)
{
    Console.WriteLine($"today is {WeekDay[i]}");
}

//here we are declaring 2D array for that we have to use , in data type
int[,] My2D = new int[3, 3];

//we are assigning a value to a 2D array
My2D[0,0] = 1;
My2D[1,0] = 2;

Console.WriteLine("here we are printing 2D array");
Console.WriteLine(My2D[0,0]);


//here we are declaring 3D array
int[,,] My3D = new int[3, 3, 3];

//here we are assigning direct value to a 2D array
//so to assign direct value to multydimention arr we have to use curly {} brackets
int[,] My2DArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


Console.WriteLine();

foreach(int i in My2DArray)
{
    Console.WriteLine(i);
}

