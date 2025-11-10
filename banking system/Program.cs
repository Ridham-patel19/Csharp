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
            File.AppendAllText(Path.Combine(Mainpath, Name.Replace(" ", "") + ".Txt"), $"User Name : {Name} \n Account type : {Accounttype} \n ");




        }

        public int Money { get; set; }




        public void Withrawl(int money)
        {
            Money = money;
            Balance = Balance - money;
            File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Withrawled money : " + Money + "\n");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());
          
        }

        public void Credited(int money)
        {
            Money = money;
            Balance = Balance + money;
            File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Credited money : " + Money + "\n");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());
            


        }

        public void Displaypassbook() 
        {
            string passbookdetail = File.ReadAllText(Path.Combine(Mainpath, "passbook.txt"));

            Console.WriteLine($"your passbook details are : \n {passbookdetail}");

        }




       
    }

   

    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = Random(2 ,10);

            UserInfo user1 = new UserInfo();
            //user1.initializinginfo("Ridham Patel", "saving account");
            //user1.Credited(1000);
            //user1.Withrawl(1000);

            //user1.Credited(1000);
            //user1.Credited(1000);
            //user1.Withrawl(1000);
            //user1.Displaypassbook();
            int n = 0;

            while(n != 4) 
            {
                Console.WriteLine($"to create an account click 1 \n to credit 2 \n to withrawl click 3 \n amd to exit 4 \n");
                 n =int.Parse(Console.ReadLine());

                switch(n) 
                {
                    case 1:

                        user1.initializinginfo("new one", "current");

                        break;

                        case 2:

                        user1.Credited(1000);

                        break;
                        case 3:

                        user1.Withrawl(100);

                        break;
                        case 4:
                           n = 4;
                        break;
                }
            }



            //UserInfo user2 = new UserInfo();
            //user2.initializinginfo("dev patel", "current account");


        }
    }
}
