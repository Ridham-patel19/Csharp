namespace constructerinheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("john", 21 , 1 , "SDE");
            john.Displayinfo();
            john.displayinfoemployee();

            Console.WriteLine(" \n multilevel inheritance constructer inheritance \n");

            Manager team = new Manager("ridhu" , 21 , 2 , "Manager" , 2);
            team.Displaymanagerinfo();
        }
    }

    class Person 
    {
        public string Name { get; private set; }
        public int Age { get; private set; }


        //constructer inheritance


        public Person(string name , int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person class constructer called");
        }
        public void Displayinfo()
        {
            Console.WriteLine($"person name is {Name} and age is {Age}");
        }
    }

    class Employee : Person 
    {

        public int Empid { get; private set; }
        public string Emprole { get; private set; }
        //its a derived class so it inherite all properties of base class 
        //so we donnot have to initlize member varible in derived class

        /*so what actually happning here is when we guve name and age in dervied constructer it will go in base construvter 
         and it will first initialize evrything according to base constructer so base class constructer will call first
        then our base constructer and then derived class constructer and we can add more things in derived class*/
        public Employee(string name , int age , int empid , string emprole) : base(name , age) 
        {
            Empid = empid;
            Emprole = emprole;
            Console.WriteLine("employee class constructer called");
        }
        public void displayinfoemployee() 
        {
            Console.WriteLine($"person name is {Name} and age is {Age}");
            Console.WriteLine($"and employee role is {Emprole} and id is {Empid}");
            
        }
    }

    class Manager : Employee 
    {
        public int TeamSize { get; set; }

        public Manager(string name, int age, int empid, string emprole, int teamsize) 
            : base(name, age, empid, emprole)
        
        {
            TeamSize = teamsize;

        }

        public void Displaymanagerinfo() 
        {
            displayinfoemployee();
            Console.WriteLine($"team size is {TeamSize}");
        }
    }
}
