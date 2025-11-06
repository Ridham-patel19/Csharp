namespace datetimeibj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime mydate = new DateTime(2005,2,1 );
            
            Console.WriteLine(mydate);

            //cuurent date
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
        }
    }
}
