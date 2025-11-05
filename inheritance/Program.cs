using System.Threading.Channels;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("\n \n");
            Dog dog = new Dog();
            Console.WriteLine("single inheritance");
            dog.eat();
            dog.Bark();

            Console.WriteLine("\n \n");
            Console.WriteLine("multiLevel inheritance");
            Tomy mydog = new Tomy();

            mydog.eat();
            mydog.Bark();
            mydog.mytomy();

            Console.WriteLine("\n \n");
            Console.WriteLine("hearchy inheritance");

            Cat cat = new Cat();
            cat.eat();
            cat.meow();

            Console.WriteLine("here i am working with new thing \n");

            /*When you define a method with the same name in the derived class but without using override,
             C# hides the base method.

             This is called method hiding, not overriding.

             At runtime, which method gets called depends on the declared type of the variable,
             not the actual object type.*/

            Console.WriteLine("\n \n");
            animal.makesound();
            dog.makesound();
            cat.makesound();

            /* so the with virtual and override key word this will call true polumorphism or method overriding 
             so with this key words u ar saying that parent class can be changed and with iverride key word 
            u r saying that child method will be replacing parent class so now with base class obj we can 'still call
             method from derived class */

            Console.WriteLine("\n \n \n");
            dog.eat();
            cat.eat();

            //what is sealed 

            //A sealed method is a method in a base class that prevents further overriding in derived classes.
            //In other words, once a method is sealed, it cannot be modified by any subclass.

            //In C#, a method can only be sealed if it is already overridden in a derived class.
            //This means you cannot seal a method directly in the base class; it must first be an overridden method. with override key word first we have use sealed key word 


            Console.WriteLine("\n \n polymorphism \n");
            //part 2 of polymorphism
            Animal myanimal = new Dog();
            myanimal.eat();



        }
    }

    class Animal 
    {


        public Animal()
        {
            Console.WriteLine("this is base class constructer");
        }
        public virtual void  eat() { Console.WriteLine("Eating..."); }
        public void makesound() { Console.WriteLine("makinng sound..."); }

        

    }
    //we use : for inheritance where fist is child class name and then parent
    //inheritance means that child class inheritate or use all members of parent class 
    //thid is a single inheritance
    class Dog: Animal
    {
        
        //here we are using base cllass constructer with derived class constructer
        public Dog() : base()
        {
            Console.WriteLine("this dog derived class constructer");
        }

        public void Bark() {
            
            base.eat();
            Console.WriteLine("barking..."); }
        public void makesound() {
           
            Console.WriteLine("barking..."); }

        public override void  eat() {
            //this is base key word with which we cn use base class properties and member method etc 
            //but we can only use it inside method and with constructer
            //base.eat();
            Console.WriteLine("eating  dog food"); }

    }

    //this is a multilevel inheritance as you can see that dog inherite from animal and then tomy 
    //tomy inherie from dog so tomy have both dog and animal classes members access
    class Tomy : Dog 
    {
        public void mytomy()
        {
            Console.WriteLine("its a street dog");
        }
    }  
    
    //this inheritance known as a hiarchy inheritance 
    //in what multiple class can derived from one base class in this ex both cat and dog are inherite from Animal
    class Cat : Animal 
    {
        public void meow() { Console.WriteLine("Meow..."); }
        public void makesound() { Console.WriteLine("meow..."); }

        public override void eat() { Console.WriteLine("cat eating..."); }

    }
}


//evrything for abstract class

//An abstract class is a class that cannot be instantiated directly. Instead,
//it serves as a blueprint for other classes. It is meant to be inherited by
//other classes that provide specific implementations for its abstract methods.

//An abstract method is a method that is declared but not defined in the
//abstract class. It must be overridden in a derived class.

//This allows developers to enforce a structure and behavior across multiple
//related classes while allowing for flexibility in implementation.


// Abstract class - cannot be instantiated
//abstract class Animal
//{
//    // Abstract method - must be implemented in derived classes
//    public abstract void MakeSound();

//    // Non-abstract method - can have a default implementation
//    public void Sleep()
//    {
//        Console.WriteLine("Sleeping...");
//    }
//}

//// Concrete class that inherits from Animal
//class Dog : Animal
//{
//    // Providing implementation for abstract method
//    public override void MakeSound()
//    {
//        Console.WriteLine("Woof! Woof!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // Animal animal = new Animal(); // ERROR: Cannot instantiate abstract class
//        Dog myDog = new Dog();
//        myDog.MakeSound(); // Output: Woof! Woof!
//        myDog.Sleep(); // Output: Sleeping...
//    }
//}