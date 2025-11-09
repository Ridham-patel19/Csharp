namespace DlegatesandEvent
{

    //`here we are using both genric and delegate so it will take any data type  function refrence
    public delegate int Comparision<T> (T x, T y);

    public class user
    {
        public int  age { get; set; }
        public string name { get; set; }

    }

    public class sortaperson
    {
        //here we are passing array of user obj and a delegate which have type of user obj 
        public void sort(user[] users,Comparision<user> compare)
        {
            for (int i = 0; i < users.Length-1; i++) 
            {
                for (int j = i + 1; j < users.Length; j++) 
                {
                    if (compare(users[i], users[j]) > 0)
                    {
                        user temp = users[i];
                        users[i] = users[j];
                        users[j] = temp;
                    }
                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            user[] users =
            {
                new user {name = "ridham" , age = 21},
                new user {name = "dev" , age = 20},
                new user {name = "mukti" , age = 42}
            };

            sortaperson person = new sortaperson();

            person.sort(users, comparebyage);

            foreach (user user in users)
            {
                Console.WriteLine(user.name + " : " + user.age);
            }

            person.sort(users, comparebyname);

            foreach (user user in users)
            {
                Console.WriteLine(user.name + " : " + user.age);
            }




        }

        public static int comparebyage(user x, user y)
        {
            return x.age.CompareTo(y.age);
        }

        public static int comparebyname(user x , user y)
        {
            return x.name.CompareTo(y.name);
        }
    }
}
