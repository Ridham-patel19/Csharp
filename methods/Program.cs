int a = 10;
int b = 20;

/*here we are declaring a method we have to specify access modifier but since we are already in the class so we can use it in class 
 we have to specify return type of a method it can return nithing also */

// these are the parameter which we are passing in thius method
 int addition(int a , int b)
{
    return a + b;
};

//here we are calling methods 
//here we are passing the arguments
int sum = addition(a,b);

Console.WriteLine(sum);


void myname(string name)
{
    Console.WriteLine(name);
};

myname("ridham");
