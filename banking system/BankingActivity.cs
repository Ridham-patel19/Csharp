using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    internal class BankingActivity : UserInfo


    {

        public long Accno { get; set; }

        public BankingActivity(long accno2)
        {
            folderPath = @"D:\bankingDB";

            Accno = accno2;
            
        }

        public BankingActivity()
        {
            folderPath = @"D:\bankingDB";
        }



        public void Withrawl(int money )
        {
            Mainpath = Path.Combine(folderPath, Accno.ToString());

            Money = money;
            Balance = int.Parse(File.ReadAllText(Path.Combine(Mainpath, "Currentbalance.txt")));
            if (Balance > Money) {
                
                Balance = Balance - money;
                File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"),"Date : " + DateTime.Now   + "\n Withrawled money : "  + Money + "\n");
                File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());
            }
            else
            {
                Console.WriteLine("you donnot have enough money");
            }

        }

        public void Credited(int money)
        {
            Mainpath = Path.Combine(folderPath, Accno.ToString());

            Money = money;
            Balance = int.Parse(File.ReadAllText(Path.Combine(Mainpath, "Currentbalance.txt")));


            Balance = Balance + money;



            File.AppendAllText(Path.Combine(Mainpath, "Passbook.txt"), "Date : " + DateTime.Now + "\n Credited money : " + Money + "\n");
            File.WriteAllText(Path.Combine(Mainpath, "Currentbalance.txt"), Balance.ToString());



        }

        public void Displaypassbook()

        {
            Mainpath = Path.Combine(folderPath, Accno.ToString());

            Console.WriteLine("hello");

            string passbookdetail = File.ReadAllText(Path.Combine(Mainpath, "Passbook.txt"));
            string balance = File.ReadAllText(Path.Combine(Mainpath, "Currentbalance.txt"));
            Console.WriteLine(balance);

            Console.WriteLine($"your passbook details are : Date :\n {passbookdetail} ");
            Console.WriteLine("\n your balance is : " + balance);

        }

    }
}
