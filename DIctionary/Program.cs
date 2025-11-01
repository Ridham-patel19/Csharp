namespace DIctionary
{


    internal class employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }


        public employee(string name,int age,int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;  

        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            //key-value key shouldnot be null
            Dictionary<int, string> student = new Dictionary<int, string>();

            student.Add(1, "john");
            student.Add(2, "joi");
            student.Add(3, "joly");
            student.Add(4, "goli");
            student.Add(5, "moli");


            string name1 = student[1];
            Console.WriteLine(name1);

            //updating a value
            student[2] = "joey";

            //removing specific id
            student.Remove(5);
            student.Remove(4);

            /*so how can we handle duplicates in it for example if we want to add new id 4 but 
             we donnot know that if this key exist or not and without knowing if we would add that 
            it will crash our app so for that we use name.containskey and then specify that so if that 
            contain a value it will return true or we can use ...*/

            if (!student.ContainsKey(4))
            {
                student.Add(4, "new name");
            }
            else
            {
                Console.WriteLine("this key alredy exist");
            }

            //it will try to add value at this key if that doesnit exist in dictionary it will return bool TRUE if it will add
            bool empty = student.TryAdd(104, "mary cooper");

            Console.WriteLine(empty);

            //so to use foreach we have to use this it will take key and value fromm student in stud
            foreach (KeyValuePair<int, string> stud in student)
            {
                Console.WriteLine("ID is " + stud.Key + " and name is " + stud.Value);
            }


            Console.WriteLine("\n \n \n  here i am using object as a value in dictionary \n \n \n ");


            Dictionary<int, employee> emp = new Dictionary<int, employee>();

            employee emp1 = new employee("rp", 21, 15000);
            employee emp2 = new employee("jp", 23, 55000);
            employee emp3 = new employee("kp", 41, 95000);
            employee emp4 = new employee("dp", 31, 25000);

            emp.Add(1, emp1);
            emp.Add(2, emp2);
            emp.Add(3, emp3);
            emp.Add(4, emp4);

            Console.WriteLine(emp[1].Name);


            emp[4].Name = "hp";

            Console.WriteLine(emp[4].Name);


            foreach(KeyValuePair<int, employee> employ in emp)
            {
                Console.WriteLine($"{employ.Key} name is {employ.Value.Name} and its salary is {employ.Value.Salary} and age is {employ.Value.Age}");
            }

            //anothr way to initialize dictionary 
            //we have write key in [] 
            var codes = new Dictionary<string, string> 
            {
                ["ridham"] = "Gujrat",
                ["john"] = "delhi",
                ["joey"] = "Noida"
            };

            foreach (var code in codes) 
            {
                Console.WriteLine(code.Key+" = "+code.Value);
            }

            if(codes.TryGetValue("john", out string state))
            {
                Console.WriteLine(state);
            }

        }
    }
}
