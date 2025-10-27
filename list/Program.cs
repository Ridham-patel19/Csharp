namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //its a list which is kind of array but its dynamic 
            List<string> colors = new List<string>();
            //add is used for adding item in list
            colors.Add("red");
            colors.Add("blue");
            colors.Add("yellow");
            colors.Add("green");
            colors.Add("red");


            //this is also way of initializing a list
            List<string> NewColors = ["magenta", "purple", "violate"];
            foreach(string color1 in NewColors)
            {
                Console.WriteLine(color1);
            }

            foreach (string color in colors) 
            {
                Console.WriteLine($"the current colors is {color}");
                
            }

            //it use for removing element we have to specify which item has to remove . this method is return boolean so if its found elemenet it will return true
           bool isDeleted =  colors.Remove("red");

            Console.WriteLine("this is new list");

            foreach (string color in colors)
            {
                Console.WriteLine($"the current colors is {color}");
                

            }
            Console.WriteLine(isDeleted);
            
        }
    }
}
