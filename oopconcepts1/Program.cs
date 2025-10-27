namespace oopconcepts1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            customer customer1 = new customer();
            customer customer2 = new customer("john");
            customer customer3 = new customer();

            customer1.Readdetail();
            customer2.Readdetail();
            customer3.Readdetail();

            //its a read only variable
            Console.WriteLine(customer2.Id);
            //its a write only varible
            customer2.Password = "1928397wbxbd73rw";

            


            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car("A3","BMW",true);

            ////its same satic method 
            //Console.WriteLine(Car.Numofcars);

            //this is a static method which only belongs to class we dont need to creat obj of it we can access this thrfough class
            //simple.mehtod();
            //creating obj/instance of an car class
            //Car audi = new Car("A3","audi",false);
            //Car BMW = new Car("M5", "BMW", true);

            //audi.Model1 = "A7";

            //Console.WriteLine(audi.Model1);

            //Console.WriteLine("Hello, World!");

            //customer ridham = new customer("ridham", "valsad", "123456789");
            //customer dev = new customer("dev");

            //customer newcustomer = new customer();
            ////here we used new custome method which we can use to set our values and its for new obj it will not change other obj
            //newcustomer.setDetail("newcustomer", "newaddress");

            //Console.WriteLine(newcustomer.Name + " " + newcustomer.ContactNum);

            //customer default1 = new customer();

            //Console.WriteLine(default1.Name + "\n" + default1.Address + "\n" + default1.ContactNum );


            //Console.WriteLine(ridham.Name + ridham.Address + ridham.ContactNum);
            //Console.WriteLine(dev.Name);

            //Car audi = new Car("A3","audi",true);
            //audi.Drive();
            //Car BMW = new Car("M5", "BMW", true);
            //here as we can see that this is the same method but it behaves diffrently and it know from which obj it is 
            //BMW.Drive();
        }
    }
}
