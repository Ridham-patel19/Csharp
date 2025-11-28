using System.IO;
using System.Security.Cryptography.X509Certificates;
namespace banking_system
{

    //public class UserInfo
    //{
    //    public string Name { get; set; }
    //    public string Accounttype { get; set; }

    //    public int Balance { get; set; }
    //    public string folderPath;
    //    public string Mainpath;


    //    public UserInfo(string name, string accno)
    //    {
    //        Name = name;
    //        Accounttype = accno;
    //        Balance = 0;


    //        folderPath = @"D:\bankingDB";

    //        Mainpath = Path.Combine(folderPath, Name.Replace(" ", ""));

    //        if (!Directory.Exists(Mainpath))
    //        {
    //            Directory.CreateDirectory(Mainpath);
    //        }
    //        File.AppendAllText(Path.Combine(Mainpath, Name.Replace(" ", "") + ".Txt"), $"User Name : {Name} \n Account type : {Accounttype} \n ");
    //        File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());




    //    }

    //    public int Money { get; set; }




    //    public void Withrawl(int money)
    //    {
    //        Money = money;
    //        Balance = int.Parse(File.ReadAllText(Path.Combine(Mainpath, "Currentbalance.txt")));
    //        Balance = Balance - money;
    //        File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Withrawled money : " + Money + "\n");
    //        File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());

    //    }

    //    public void Credited(int money)
    //    {
    //        Money = money;
    //        Balance = int.Parse(File.ReadAllText(Path.Combine(Mainpath , "Currentbalance.txt")));
    //        Balance = Balance + money;



    //        File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Credited money : " + Money + "\n");
    //        File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());



    //    }

    //    public void Displaypassbook()

    //    {

    //        string passbookdetail = File.ReadAllText(Path.Combine(Mainpath, "passbook.txt"));
    //        string balance = File.ReadAllText(Path.Combine(Mainpath, "Currentbalance.txt"));

    //        Console.WriteLine($"your passbook details are : \n {passbookdetail}");
    //        Console.WriteLine("\n your balance is : " + balance);

    //    }

    //    public UserInfo LogIN(string name, Dictionary<string, UserInfo> user)
    //    {
    //        name = name.Replace(" ", "");
    //        UserInfo value;
            
    //        if (user.TryGetValue(name.ToLower(), out value))
    //        {
    //            return value;
    //        }
    //        return null;
           
    //    }

        




    //}



    internal class Program
    {
        static void Main(string[] args)
        {
            //UserInfo user = new UserInfo();
            BankingActivity activity = new BankingActivity();
            Security secure = new Security();

            Console.WriteLine("===================WELC0ME TO RP'S BANKING SYSTEM=================== \n \n");


            int choosed = 0;



            while (choosed != 3)
            {
                Console.WriteLine("What do you want to do \n 1. create an account \n 2. login in to a existence account \n 3. Exit");
                string choice = Console.ReadLine();
                
                
                choosed = int.Parse(choice);

                switch (choosed)
                {
                    case 1:

                        Console.WriteLine("please enter your name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("please enter acccount type : ");
                        string accounttype = Console.ReadLine();
                        Console.WriteLine("plese enter your password");
                        string password = Console.ReadLine();
                        activity.CreateAccount(name , accounttype , password);
                        long accno = activity.AccountNo;
                        manu(activity);

                        break;

                        case 2:

                        

                        Console.WriteLine("plese enter your account number  : ");
                        string tempaccno = Console.ReadLine();
                        long LogAccountno;

                        long.TryParse(tempaccno,out LogAccountno);

                        BankingActivity bankact = new BankingActivity(LogAccountno);

                        Console.WriteLine("please enter your password : ");
                        string Logpassword = Console.ReadLine();

                        if(secure.LogIN(LogAccountno , Logpassword))
                        {
                            manu(bankact);
                        }
                        else
                        {
                            Console.WriteLine("something went wrong");
                        }

                        break;
                }

            }


               

            

            

        }
            
    



        //UserInfo user2 = new UserInfo();
        //user2.initializinginfo("dev patel", "current account");

       //public static bool isvalid()
       // {
       //     bool isbool = true;
       //     while (isbool)
       //     {
       //         Console.WriteLine(" Enter your choice : ");
       //         string choice = Console.ReadLine();
       //         int result;
       //         if (!(int.TryParse(choice, out result)))
       //         {
       //             isbool = false;
       //             return false;
       //         }

       //     }

       //         return true;
            
       // }

        public static void manu(BankingActivity activity )
        {
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
                        activity.Credited(amount );
                        break;
                    case 2:
                        Console.WriteLine("Enter the Amount you want to withdrawl");
                        amount = int.Parse(Console.ReadLine());


                        activity.Withrawl(amount);
                        break;
                    case 3:
                        Console.WriteLine(
                            " hey its running");
                        activity.Displaypassbook();
                        break;
                }
            }

        }


    }
}
