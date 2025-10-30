namespace Objectwithlist
{

    internal class product 
    {
        public String Name { get; set; }
        public double Price { get; set; }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<product> Products = new List<product>()
            {
                new product{Name="colgate",Price = 150},
            };

            Products.Add(new product { Name = "barries", Price = 20 });

            foreach (product items in Products) 
            {
                Console.WriteLine(items.Name);
            }


            //its also a predicates a function which will not return list
            //so i have to civert it to list and it will return a mer list
            List<product> cheapitems = Products.Where(p => p.Price < 50).ToList();

            foreach(product items in cheapitems)
            {
                Console.WriteLine(items.Name);
            }


        }
    }
}
