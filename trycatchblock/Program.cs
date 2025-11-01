using System.Diagnostics;

namespace trycatchblock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            //this is something which devloper need so only devloper can see this but not the user 
            Debug.WriteLine("main method is running");
            try
            {
                Console.WriteLine("Please enter a number");
                int a = int.Parse(Console.ReadLine());
                int b = 10;
                int result = b / a;
                Console.WriteLine("reasult is : "+result);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("PLEASE ENETER A NUMBER!" + ex.Message);
            }catch(DivideByZeroException ex) 
            {
                Console.WriteLine("PLEASE ENTER NUMBER OTHER THEN ZERO" + ex.Message);
            }
            catch (Exception e) 
            {
                //this will print  whole exception
                //Console.WriteLine(e.ToString());
                //this will only print the eror msg
                Console.WriteLine(e.Message);
                Debug.WriteLine(e.ToString());
            }
            finally { Console.WriteLine("this will always executes"); }
        }
    }
}
