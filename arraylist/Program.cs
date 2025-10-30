using System.Collections;

namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array list is one type of list but it can store any obj do so any data type
            ArrayList Mylist = new ArrayList();
            ArrayList Mylist2 = new ArrayList(100);


            Mylist2.Add(12);
            Mylist2.Add(13.1234);
            Mylist2.Add(14.3);
            Mylist2.Add(15);
            Mylist2.Add(16);
            Mylist2.Add("hello");

            //ut removes specific element
            Mylist2.Remove(12);

            //it removes element at specific index
            Mylist2.RemoveAt(3);

            Console.WriteLine("hello world");

            foreach (object i in Mylist2) 
            {
                
                Console.WriteLine(i);

                if (i is string) 
                {
                    Console.WriteLine("this is ur string " + i);
                }
            }

        }
    }
}
