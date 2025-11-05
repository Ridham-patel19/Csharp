namespace fileIO
{
    internal class Program
    {

        public interface Ilogger
        {
            void log(string message);
        }

        public class filelogger : Ilogger
        {
            public void log(string message)
            {
                //we are working with file IO so with work with that we uses Filr class
                //too see file you have to go in this file/bin/debug/net 8.0
                //try
                //{
                //    File.AppendAllText("log1.txt", "hello this is my first file");
                //    Console.WriteLine("text added");
                //}
                //catch (Exception ex) { Console.WriteLine("there is something wrong"); }


                //this will read all lines and returns a string array 


                //here @ means it will take ll that in string "\" will be treated normal other wise its a escape character
                string direactorypath = @"d:\logs";

                string filepath = Path.Combine(direactorypath, "log1.txt");

                if (!Directory.Exists(direactorypath))
                {
                    Directory.CreateDirectory(direactorypath);
                }

                File.AppendAllText(filepath, message + "\n");

                //string[] file = File.ReadAllLines(filepath);
                //foreach (string line in file) { Console.WriteLine(line); }
            }

            public class databaselogger : Ilogger
            {
                public void log(string message)
                {
                    Console.WriteLine("data base loges in" + message);
                }
            }

            public class Application
            {
                private readonly Ilogger _logger;

                public Application(Ilogger logger)
                {
                    _logger = logger;
                }

                public void Dowork(string message)
                {
                    _logger.log(message);
                    Console.WriteLine(message);

                }

            }
            static void Main(string[] args)
            {


                Ilogger logger = new databaselogger();
                Application app = new Application(logger);
                app.Dowork("working with database");

                Ilogger logger2 = new filelogger();
                app = new Application(logger2);
                app.Dowork("working with files");





            }
        }
    }
}
