using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopconcepts1
{
    internal class Car
    {
        private string _model = "";
        public static int Numofcars = 0;
        //here we can comment out we are only using init normal we arent doing something with it
        //private bool _isluxury;

        /*here we have to declare private _brand cuz we are manual settinmg everu=ythung like what we have to do if someone 
         is accesssing brand variable */
        private string _brand;

        /*so we can directly make an property for it its called automatic property its just like not=rmal creating varible but 
         when we use this and we compile this then compiler creates hidden private variable for this properties which is hif=*/
        public bool IsLuxury { get; set; }


        //properties for encapsulation
        public string Model1 { get => _model;

            set { 
              if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("you have to enmter something");
                }
                else
                {
                    _model = value;
                }
            }
        }

        //here we are getting the value of brand means when someone want to access brand is goes through this
        public string Brand {
            get {
                if (IsLuxury)
                {
                    return _model + " is luxury";
                }
                else
                {
                    return _model + " is not luxury";
                }
            }
            set {
                
            }
        }

        public Car(string model,string brand, bool isluxury)
        {
            Model1 = model;
            Console.WriteLine("this car model is " + Model1 );
            Console.WriteLine("our car class object is created");
            IsLuxury = isluxury;
            Brand = brand;
            Console.WriteLine(Brand);
            Numofcars++;
            
        }

        public Car()
        {
            Numofcars++;
        }

        public void Drive() {
            Console.WriteLine($"this is {Model1} and this car is driving");
        }
    }
}
