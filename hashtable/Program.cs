using System.Collections;

namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //this all store the object 
            Hashtable Studenttable = new Hashtable();


            //so here float stire point value but we have to add f in last cuz by default c# takes it as double
            Student stud1 = new Student(1,"rudra",7.1f);
            Student stud2 = new Student(2, "het", 5.2f);
            Student stud3 = new Student(3, "hetvi", 6.2f);
            Student stud4 = new Student(4, "dev", 9.2f);
            Student stud5 = new Student(5, "harsh", 3.2f);

            Studenttable.Add(stud1.Id, stud1);
            Studenttable.Add(stud2.Id, stud2);
            Studenttable.Add(stud3.Id, stud3);
            Studenttable.Add(stud4.Id, stud4);
            Studenttable.Add(stud5.Id, stud5);

            Student allstudent = (Student)Studenttable[1];

            foreach (DictionaryEntry item in Studenttable) 
            {
                Student allstudentthere = (Student)item.Value;
                Console.WriteLine(allstudentthere.Name);
            }

            Console.WriteLine($"student{allstudent.Id} and its name is {allstudent.Name} and gpa is {allstudent.Gpa}");




        }
    }

    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Gpa { get; set; }


        public Student(int id , string name , float gpa)
        {
            this.Id = id;
            this.Name = name;   
            this.Gpa = gpa;
        }

    }
}
