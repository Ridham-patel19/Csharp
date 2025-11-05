namespace sealedkeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parent par = new Parent();
            Child chil = new Child();   
        }
    }

    class Parent
    {
        public Parent()
        {
            Console.WriteLine("this is parent class ");
        }
    }

    //sealed key word is used so no other class can derive from it
    sealed class Child : Parent 
    {
        public Child() 
        {
            Console.WriteLine("this is the first child class");
        }
    }


    //but as we have sealed child class we can not derived from it
    //class Child : john { }



    //as you can see we havenot used sealed on base class we can use that 
    class child2 : Parent 
    
    {
        public child2()
        {
            Console.WriteLine("deroved from base class 2nd child");
        }
    }
        

}
