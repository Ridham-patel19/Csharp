namespace nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //as you can see we cant assign null to a specific data types 
            //int num = null;

            //so we have to add ? after datatype to make it nullable
            int? num = null;
            int num2 = 10;
            num = 10;

            //this is special method for nullable to check weather it has a value or not 
            if (num.HasValue)
            {

                //so we can only use .value method when it has value 
                Console.WriteLine("the value is " + num.Value);
            }

            else 
            {
                //this will throw error cuz variable is null right
                //int Myage = num.Value + num2;

                Console.WriteLine("the variable is null");
            }
        }
    }
}
