using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace banking_system
{

    public class UserInfo
    {
        public string Name { get; set; }
        public string Accounttype { get; set; }

        public int Balance { get; set; }
        public string folderPath;
        public string Mainpath;


        public UserInfo(string name, string accno)
        {
            Name = name;
            Accounttype = accno;
            Balance = 0;


            folderPath = @"D:\bankingDB";

            Mainpath = Path.Combine(folderPath, Name.Replace(" ", ""));

            if (!Directory.Exists(Mainpath))
            {
                Directory.CreateDirectory(Mainpath);
            }
            File.AppendAllText(Path.Combine(Mainpath, Name.Replace(" ", "") + ".Txt"), $"User Name : {Name} \n Account type : {Accounttype} \n ");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());




        }

        public int Money { get; set; }




        public void Withrawl(int money)
        {
            Money = money;
            Balance = int.Parse(File.ReadAllText(Path.Combine(Mainpath, "Currentbalance.txt")));
            Balance = Balance - money;
            File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Withrawled money : " + Money + "\n");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());

        }

        public void Credited(int money)
        {
            Money = money;
            Balance = int.Parse(File.ReadAllText(Path.Combine(Mainpath , "Currentbalance.txt")));
            Balance = Balance + money;



            File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Credited money : " + Money + "\n");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());



        }

        public void Displaypassbook()

        {

            string passbookdetail = File.ReadAllText(Path.Combine(Mainpath, "passbook.txt"));
            string balance = File.ReadAllText(Path.Combine(Mainpath, "Currentbalance.txt"));

            Console.WriteLine($"your passbook details are : \n {passbookdetail}");
            Console.WriteLine("\n your balance is : " + balance);

        }

        public UserInfo LogIN(string name, Dictionary<string, UserInfo> user)
        {
            name = name.Replace(" ", "");
            UserInfo value;
            
            if (user.TryGetValue(name.ToLower(), out value))
            {
                return value;
            }
            return null;
           
        }

        




    }



    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = Random(2 ,10);

            Dictionary<string, UserInfo> UserNames = new Dictionary<string, UserInfo>();


            //UserInfo user = new UserInfo();
            //user1.initializinginfo("Ridham Patel", "saving account");
            //user1.Credited(1000);
            //user1.Withrawl(1000);

            //user1.Credited(1000);
            //user1.Credited(1000);
            //user1.Withrawl(1000);
            //user1.Displaypassbook();
            int n = 0;

            Console.WriteLine("Welcome to the RP Banking system \n");
            Console.WriteLine("\n -----------------------------------------------------------------------------------------");

            while (n != 3)
            {
                Console.WriteLine($"\n to create an account click 1 \n to login 2 \n to exit 3 \n ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("\n -----------------------------------------------------------------------------------------");

                if (n <= 0 || n > 3)
                {
                    Console.WriteLine("Please Enter valid number : \n");
                    Console.WriteLine($"\n to create an account click 1 \n to login 2 \n to exit 3 \n ");
                    n = int.Parse(Console.ReadLine());
                }

                switch (n)
                {
                    case 1:
                        Console.WriteLine("please eneter your name : ");
                        string username = Console.ReadLine();
                        Console.WriteLine("please enter your account type you want : ");
                        string acctype = Console.ReadLine();

                        Console.WriteLine("\n -----------------------------------------------------------------------------------------");
                        //user.initializinginfo(username, acctype);
                        UserNames.Add(username.ToLower(), new UserInfo(username, acctype));
                        int choosed = 0;
                        
                        while (choosed != 4)
                        {
                            Console.WriteLine("\n to credit 1 \n to withdrawl 2 \n to see passbook 3 \n to exit 4 \n");
                             choosed = int.Parse(Console.ReadLine());

                            if(choosed <= 0 || choosed > 4)
                            {
                                Console.WriteLine("Please Enter valid number : \n");
                                Console.WriteLine("\n to credit 1 \n to withdrawl 2 \n to see passbook 3 \n to exit 4 \n");
                                choosed = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n -----------------------------------------------------------------------------------------");
                            }
                            switch (choosed)
                            {
                                case 1:
                                    Console.WriteLine("Enter the Amount you want to credit");
                                    int amount = int.Parse(Console.ReadLine());
                                    UserNames[username].Credited(amount);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Amount you want to withdrawl");
                                     amount = int.Parse(Console.ReadLine());
                                    UserNames[username].Withrawl(amount);
                                    break;
                                case 3:
                                    UserNames[username].Displaypassbook();
                                    break;
                            }
                        }


                        break;

                    case 2:

                        Console.WriteLine("please eneter your name same as account name");
                        string Name = Console.ReadLine();
                        Name = Name.ToLower();

                        Name = ifcontains(Name , UserNames);

                       
                        
                        Console.WriteLine("\n -----------------------------------------------------------------------------------------");
                        

                        UserInfo curruser = UserNames[Name].LogIN(Name, UserNames);

                        int choosed2 = 0;
                        while (choosed2 != 4)
                        {
                            Console.WriteLine("\n to credit 1 \n to withdrawl 2 \n to see passbook 3 \n to exit 4 \n");
                             choosed2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n -----------------------------------------------------------------------------------------");
                            if (choosed2 <= 0 || choosed2 > 4)
                            {
                                Console.WriteLine("Please Enter valid number : \n");
                                Console.WriteLine("\n to credit 1 \n to withdrawl 2 \n to see passbook 3 \n to exit 4 \n");
                                choosed2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("\n -----------------------------------------------------------------------------------------");
                            }
                            switch (choosed2)
                            {
                                case 1:
                                    Console.WriteLine("Enter the Amount you want to credit");
                                    int amount = int.Parse(Console.ReadLine());
                                    curruser.Credited(amount);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the Amount you want to withdrawl");
                                     amount = int.Parse(Console.ReadLine());


                                    curruser.Withrawl(amount);
                                    break;
                                case 3:
                                    curruser.Displaypassbook();
                                    break;
                            }
                        }



                        break;


                }
            }
            
    }



        //UserInfo user2 = new UserInfo();
        //user2.initializinginfo("dev patel", "current account");

        public static string ifcontains(string name, Dictionary<string, UserInfo> user)
        {

            if (user.ContainsKey(name.ToLower()))
            {
                return name;
            }

            Console.WriteLine("please eneter your name same as account name");
             name = Console.ReadLine();
            name = name.ToLower();
            ifcontains(name, user);
            return null;
        }


    }
}
