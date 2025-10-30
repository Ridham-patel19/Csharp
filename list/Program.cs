namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // //its a list which is kind of array but its dynamic 
           // List<string> colors = new List<string>();
           // //add is used for adding item in list
           // colors.Add("red");
           // colors.Add("blue");
           // colors.Add("yellow");
           // colors.Add("green");
           // colors.Add("red");


           // //this is also way of initializing a list
           // List<string> NewColors = ["magenta", "purple", "violate"];
           // foreach(string color1 in NewColors)
           // {
           //     Console.WriteLine(color1);
           // }

           // foreach (string color in colors) 
           // {
           //     Console.WriteLine($"the current colors is {color}");
                
           // }

           // //it use for removing element we have to specify which item has to remove . this method is return boolean so if its found elemenet it will return true
           //bool isDeleted =  colors.Remove("red");

           // Console.WriteLine("this is new list");

           // foreach (string color in colors)
           // {
           //     Console.WriteLine($"the current colors is {color}");
                

           // }
           // Console.WriteLine(isDeleted);

            List<int> num = new List<int>() {4,2,6,1,3,4,5,6 , 30};


            //this function will return new list according to the condition on code we have
            //this is lamda expression its sort way to write a methid 
            List<int> newlist = num.FindAll(x=> x >= 4);
            Console.WriteLine("this is ia a newlist");
            foreach (int x in newlist) { Console.WriteLine(x); }
            Console.WriteLine("this is un sorted list");
            foreach (int a in num)
            {
                Console.WriteLine(a);
            }
            num.Sort();
            Console.WriteLine("now sorted list");

            foreach (int a in num)
            {
                Console.WriteLine(a);
            }

            //this is a function which will check certain conf=dition in list and return a boolean
            bool results = num.Any(x => x>20);

            if (results) 
            {
                Console.WriteLine("there are greater values then 20");
            }



            //its one type of delegate a way of writing programme in which it will take only one input and returns a boolean
            Predicate<int> isgreaterthen = x => x >= 4;

            bool boolean = isgreaterthen(5);
            Console.WriteLine(boolean);


            
            
        }
    }
}
