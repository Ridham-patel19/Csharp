namespace structure
{
    internal class Program
    {

        //struct is just like class but i cannot be inherite 
        public struct point 
        {
            public int X;
            public int Y;

            public point(int x , int y)
            {
                Y = y;
                X = x;
            }

            public void display () 
            {
                Console.WriteLine($"printing x = {X} and y = {Y}");
            }
        }
        static void Main(string[] args)
        {
           point num = new point(10,20);
            num.display();
            point num2;
            num2.X = 10;
            num2.Y = 20;
            num2.display();

            point num3 = num2;
            num3.X = 600;
            num3.display();
        }
    }
}
