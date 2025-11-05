namespace interfacess
{

    //so a interface is contract which we can use with class and we can define method properties 
    // event etc in interface we can only declare it so we canot define it in so its just signature 
    //and whenever we use this with class we have  to implement all that interface have 

    public interface IEmployee 
    {
        void nameDisplay(string name);
        void jobroleDisplay();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp = new Emp();

            emp.jobroleDisplay();
            emp.nameDisplay("john");
            
        }
    }

    class Emp : IEmployee
    {
        //as you can see in interface there i=only method name but in this class we omplement that methods
        public void jobroleDisplay()
        {
            Console.WriteLine("your job role is SDE");
        }

        public void nameDisplay(string name)
        {
            Console.WriteLine("your name is "+ name);  
        }
    }
}