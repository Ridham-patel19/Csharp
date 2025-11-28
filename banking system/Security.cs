using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    internal class Security
    {
        public string folderPath;
        public string Mainpath;
        public Security()
        {
            //folderPath = @"D:\bankingDB";
            folderPath = @"D:\bankingDB";

            


        }

        public bool LogIN(long accountno , string password)
        {
            //long accountno;
            //string password;
            //Console.WriteLine("please Enter account number : ");
            //if (!long.TryParse(Console.ReadLine(), out accountno))
            //{
            //    Console.WriteLine("Invalid account number.");
            //    return false;
            //}

            //Console.WriteLine("please eneter password : ");
            //password = Console.ReadLine();


            
            Mainpath = Path.Combine(folderPath, accountno.ToString());
            Console.WriteLine(Mainpath);
            if (!(File.Exists(Path.Combine(Mainpath, "AccountNumber.txt"))))
            {
                Console.WriteLine("account number is wrong");

                return false;
            }

             if(!(File.Exists(Path.Combine(Mainpath, "password.txt"))))
            {
                Console.WriteLine("Password is wrong");
                return false;
            }
            long OGaccountno = long.Parse(File.ReadAllText(Path.Combine(Mainpath, "AccountNumber.txt")));

            //Console.WriteLine(OGaccountno.ToString());




            string ogpass = File.ReadAllText(Path.Combine(Mainpath, "password.txt"));

            if (password != ogpass || accountno != OGaccountno)
            {
                Console.WriteLine("please eneter valid detail");

                return false;
            }
            

            return true;
            //return LogIN() ;
        }
    }
}
