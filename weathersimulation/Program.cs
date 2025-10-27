using System.Runtime.InteropServices;

namespace weathersimulation
{
    internal class Program
    {
        int max;
        int min;
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number of days you want");
            int days = int.Parse(Console.ReadLine());

            int[] temprature = new int[days];
            string[] condition = { "sunny", "cloudy", "rainy", "smokey", "thunderstorm" };
            string[] weathercondition = new string[days];

            Random random = new Random();
            for (int i = 0; i <= days - 1; i++)
            {
                temprature[i] = random.Next(-10, 40);
                weathercondition[i] = condition[random.Next(condition.Length)];
                Console.WriteLine(weathercondition[i]);
                Console.WriteLine(temprature[i]);
            }

            Program obj = new Program();
            
            Console.WriteLine(obj.avg(days,temprature));

            obj.maxmin(days, temprature);
            string common = obj.commomncondition(weathercondition);

            Console.WriteLine("the most common condition is " + common);

            Console.WriteLine("minimum temprature is " + obj.min);
            Console.WriteLine("maximum temprature is " + obj.max);
        }

        int avg(int days, int[] temprature)
        {
            int sum = 0;
            for (int i = 0; i <= days -1; i++)
            {
                sum = sum + temprature[i];
            }
            return sum / days;

        }
        void maxmin(int days, int[] temprature)
        {
            max = temprature[0];
            for (int i = 1;i <= days - 1; i++)
            {
                max = temprature[i];
                if (temprature[i] >= max)
                {
                    max = temprature[i];
                }
            }
            min = temprature[0];
            for (int i = 1; i <= days - 1; i++)
            {
                
                if(temprature[i] <= min)
                {
                    min = temprature[i];
                }
            }
        }

        string commomncondition(string[] condition)
        {
            int maxcount = 0;
            string curcondition = condition[0];
            
            for (int i = 1; i < condition.Length; i++)
            {
                int tempcount = 0;
                for (int j = 0; j < condition.Length; j++)
                {
                    if (condition[i] == condition[j])
                    {
                        tempcount++;
                    }
                }
                if (tempcount >= maxcount)
                {
                    maxcount = tempcount;
                    curcondition = condition[i];
                }
            }

            return curcondition;
        }
    }
}
