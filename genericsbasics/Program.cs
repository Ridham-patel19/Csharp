namespace genericsbasics
{
    internal class Program
    {
        /*genrics makes our code flrxible while we work with datatype and also its for type safety 
         it guve erroe at compile time not run time and its like working with genral data type nad guves 
        dadata type at compile  time*/
        static void Main(string[] args)
        {
            //as we can see that w ecan use same method for al this data types
            int[] arr1 = { 1, 2, 3 };
            printarray(arr1);

            string[] arr2 = { "a", "b", "c" };
            printarray(arr2);
        }
        //its a generic method as you can see that T refers to general type 
        public static void printarray<T>(T[] arr)
        {
            foreach(T item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
