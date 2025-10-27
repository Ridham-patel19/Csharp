using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopconcepts1
{
    internal class customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public string ContactNum { get; set; }

        //readonly key word means we can only assigned once after we cannot change it
        private readonly int _id;

        //here Id is read only cuz its only have get which means we can only get not set it 
        public int Id { get 
            {
                return _id;
            } 
        }

        private static int Nextid = 0;

        private string _password;

        /*so its a write only properties for example password we dont want saw passwprd to user but user can write it*/
        public string Password { set
            {
                _password = value;
            } 
        }
        
        

        //custome constructer
        public customer(string name,string address,string contactnum )
        {
            _id = Nextid++;
            Name = name;
            Address = address;
            ContactNum = contactnum;
        }

        public customer(string name)
        {
            _id=Nextid++;
            Name = name;
        }

        //this is a defualt constructer so when we dont pass anything we can use default constructer 
        public customer()
        {
            _id = Nextid++;
            Name = "uknown";
            Address = "uknown";
            ContactNum = "0000000000";
        }


        public void Readdetail()
        {
            Console.WriteLine("the id is " + _id + " and the name is "+ Name );
        }
        //so this is a custome method which we can use many time as we want 
        //so we can set a default value for argument so if dont pass any argumn=ent it will take this default value
        public void setDetail(string name, string address, string contactnum = "NA")
        {
            
            Name = name;
            Address = address;
            ContactNum = contactnum;
        }
    }
}
