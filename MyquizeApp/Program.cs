namespace MyquizeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quetion[] quetions = new Quetion[]
            {
                new Quetion("what is 2 + 2" ,
                new string[] {"4","3","2","1"},0

                ),
                new Quetion("what is the capital of india",new string[] {"gujrat","gandhinagar","mumbai","delhi"},3),
                new Quetion("who is indias captain in 2011 CWC",new string[]{"kapil dev","sachin","virat","dhoni"},3),
                new Quetion("what is normally size of int data type",new string[] {"4","3","2","1"},0),
                new Quetion("on which side of body heart is located",new string[] {"left","right","both side","none"},0) 
            };


            quize quize1 = new quize(quetions);

            quize1.StartQuize();
        }
    }
}
