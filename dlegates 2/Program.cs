namespace dlegates_2
{

    public delegate void loghandller();

    public class log 
    {
        public void logginginconsole()
        {
            Console.WriteLine("logged in console");
        }

        public void loggininfile()
        {
            Console.WriteLine("logges in file");
        }
    }
    internal class Program
    {


        static void Main(string[] args)
        {
            //log log1 = new log();
            // loghandller loghanndler1 = log1.logginginconsole;
            // loghanndler1();

            // loghanndler1 = log1.loggininfile;
            // loghanndler1();

            log log1 = new log();
            loghandller loghanndler1 = log1.logginginconsole;
            //its a multicast delagates means we are assigning more then one metghod to and it will run in order which the assignrd
            loghanndler1 += log1.loggininfile;

            //get invocationlist will return list of all delagates in loghandler its just a safer way to run this
            foreach (loghandller handler in loghanndler1.GetInvocationList()) 
            {
                try
                {
                    handler();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("there might be some error");
                }
            }
            invokingsafely(loghanndler1);
            //loghanndler1();
        }

        public static void invokingsafely(loghandller loghandle)
        {
            loghandller temp = loghandle;

            if (temp != null)
            {
                temp();
            }
        }
    }
}
