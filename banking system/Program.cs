using System.IO;
namespace banking_system
{

    public class UserInfo
    {
        public string Name { get; set; }
        public string Accounttype { get; set; }

        public int Balance { get; set; }
        public string folderPath;
        public string Mainpath;


        public void initializinginfo(string name ,string accno )
        {
            Name = name;
            Accounttype = accno;
            Balance = 0;

           
            folderPath = @"D:\bankingDB";

             Mainpath = Path.Combine(folderPath, Name.Replace(" ",""));

            if (!Directory.Exists(Mainpath)) 
            {
                Directory.CreateDirectory(Mainpath);
            }
            saveinfo();




        }

        public int Money { get; set; }




        public void Withrawl(int money)
        {
            Money = money;
            Balance = Balance - money;
            File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Withrawled money : " + Money + "\n");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());
            saveinfo();
        }

        public void Credited(int money)
        {
            Money = money;
            Balance = Balance + money;
            File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Credited money : " + Money + "\n");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());
            saveinfo() ;


        }




        private void saveinfo()
        {
           
            File.AppendAllText(Path.Combine(Mainpath, Name.Replace(" ", "") + ".Txt"), $"User Name : {Name} \n Account type : {Accounttype} \n Balnce : {Balance} \n");

            //if(Directory.Exists())
        }
    }

   

    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = Random(2 ,10);

            UserInfo user1 = new UserInfo();
            user1.initializinginfo("Ridham Patel", "saving account");
            user1.Credited(10000);
            user1.Withrawl(200);

            user1.Credited(1000);
            Console.WriteLine(user1.Balance);
            
            

            //UserInfo user2 = new UserInfo();
            //user2.initializinginfo("dev patel", "current account");

            
        }
    }
}
