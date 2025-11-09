namespace delgates
{
    internal class Program
    {

        //delegation is refrence to another function itd like pointer to function

        //declarartion
        //as you can see it doesnot have any body
        public delegate void Notify(string msg);
        static void Main(string[] args)
        {
            //defination / defining
            //there are 2 way we can initiate it
            Notify notify = new Notify(messages);
            Notify notify2 = messages;

            //calling / invocation
            notify("hello this is my delagate");

            var sqrt = (int s) => s * s;

            Console.WriteLine(sqrt(3));
        }

        static void messages(string msg) 
        {
            Console.WriteLine(msg);
        }
    }
}
