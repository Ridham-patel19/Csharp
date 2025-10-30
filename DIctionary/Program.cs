namespace DIctionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //key-value key shouldnot be null
           Dictionary<int,string> student = new Dictionary<int,string>();

            student.Add(1, "john");
            student.Add(2, "joi");

            string name1 = student[1];
            Console.WriteLine(name1);
        }
    }
}
