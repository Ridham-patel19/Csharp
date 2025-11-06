namespace enums
{
    internal class Program
    {
        public enum Day {  mon,tue,wed,thu,fri,sat,sun }
        static void Main(string[] args)
        {
            Day day = Day.mon;

            Day one = Day.mon;

            Console.WriteLine(day == one);

            Console.WriteLine(day);
            Console.WriteLine((int)day);


        }
    }
}
