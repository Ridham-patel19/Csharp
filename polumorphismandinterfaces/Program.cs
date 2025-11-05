namespace polumorphismandinterfaces
{

    public interface IPaymentSystem 
    {
        void Paymentprocessor(decimal amount);
    }

    public class CreditCard : IPaymentSystem
    {
        public void Paymentprocessor(decimal amount) 
        {
            Console.WriteLine($"your total payment abount is {amount}");
        }
    }

    public class Gpay : IPaymentSystem 
    
    {
        public void Paymentprocessor(decimal amount) 
        {
            Console.WriteLine($"you total amont in gpay is {amount}");
        }
    }

    public class Processor 
    {
        private readonly IPaymentSystem _process;

        public  Processor(IPaymentSystem process) 
        {
            _process = process;

        }

        public void processpayment(decimal amount) 
        {
            _process.Paymentprocessor(amount);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentSystem credit = new CreditCard();
            Processor processor = new Processor(credit);
            
            processor.processpayment(100.00m);


            IPaymentSystem gpay = new Gpay();
           Processor processor2 = new Processor(gpay);
            processor2.processpayment(200.00m);
        }
    }
}
