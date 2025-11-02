
namespace accessmodifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            second sec = new second();
            sec.print();
            first fr = new first();
            fr.accessingprivate();
            Console.WriteLine("accessing in main method \n");

            Console.WriteLine($" public variable : {sec.num++} \n ");
        }
    }

    class first
    {
        //can access any where in project
        public int num = 0;
        //can access in its own class and derived classes
        protected int num2 = 0;
        //can only access in its own class
        private int num3 = 0;

        public void accessingprivate() 
        {
            Console.WriteLine("this is private one which i am accesing through its own class : " + ++num3 + "\n");
        }

    }

    class second : first 
    {
        public void print() 
        {
            Console.WriteLine($"the first public variable : {++num} then second protected : {++num2} third private which we cannot acccess \n");
        }
    }
}
