namespace abstracty_class
{
    internal class Program
    {

        //abstract class are also class but we cannot create instance of it . it only used for inheritance like a constract
        public abstract class Worker
        {
            public int num { get; set; }
            public abstract int num2 { get; set; }

            protected Worker()
            {
                Console.WriteLine("abstract class constructer called");
            }

            //abstract method ha sno body
            public abstract void working();

            //we can add normal method and normal feildes etc and cinstructer too
            public void workdone()
            {
                Console.WriteLine("work has done");
            }
        }

        //its just like interface we have to impplement abstract methods with ovverride key word 
        public class SDE : Worker
        {
            public override int num2 { get; set; }

            public override void working()
            {
                Console.WriteLine(" i am working on software");
            }

            public SDE() : base()
            {
                {
                    Console.WriteLine("childe class constructer");
                }
            }
            static void Main(string[] args)
            {
                SDE john = new SDE();
                john.working();
                john.workdone();

            }
        }
    }
}
