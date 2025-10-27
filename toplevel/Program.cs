namespace toplevel
{
    internal class Program
    {
        //this is a instance of a class or feild of a class we have to use static or create instance of it to use it in main method
        static int myResult;
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;

            int x = 20;
            int y = 30;

            myResult = substract(a,b);
            Console.WriteLine(myResult);

            //we are creating obj of a prgramme class 
            Program obj = new Program();

            //calling add method from a programme class
            int result2 = obj.add(x, y);

            Console.WriteLine(result2);
;        }

        //here we are defining method out side of main method 
        /*we are using static key word which means we can use this method without creating instance of it*/
        static int substract(int x , int y)
        {
            return x - y;
        }

        //here we are defining method without static so we have to create obj of this programme class
        int add(int x, int y) {
            return x + y;
        }

    }
}
