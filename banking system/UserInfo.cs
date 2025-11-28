using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    public class UserInfo
    {

       
        public string Name { get; set; }
        public string Accounttype { get; set; }

        public int Balance { get; set; }
        public string folderPath;
        public string Mainpath;
        //long a = 1223456778809999;
        public long AccountNo { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }

        //public UserInfo()
        //{
        //    folderPath = @"D:\bankingDB";

        //    Mainpath = Path.Combine(folderPath, AccountNo.ToString());
        //}
        private static Random rand = new Random();

       
        public void CreateAccount(string name , string acctype  , string password )
        {
           

            Name = name;
            Accounttype = acctype;
            AccountNo = rand.Next(10000000, 1000000000);
            Password = password;
            Balance = 0;
            Money = 0;

            folderPath = @"D:\bankingDB";

            Mainpath = Path.Combine(folderPath, AccountNo.ToString());





            if (!Directory.Exists(Mainpath))
            {
                Directory.CreateDirectory(Mainpath);
            }

            File.AppendAllText(Path.Combine(Mainpath, Name.Replace(" ", "") + ".Txt"), $"User Name : {Name} \n Account type : {Accounttype} \n ");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());
            File.WriteAllText(Path.Combine(Mainpath, "AccountNumber.txt"), AccountNo.ToString());
            File.WriteAllText(Path.Combine(Mainpath, "password.txt"), Password);

            Console.WriteLine("your account no is : " + AccountNo);

        }
    }
}
