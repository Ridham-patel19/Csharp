
namespace dependancies
{

    public interface Itooluser 
    {
        void setHammer(Hammer hammer);
        void setSaw(Saw saw);
    }

    public class Hammer
    {
        public void use() { Console.WriteLine("using hammer"); }
    }

    public class Saw
    {
        public void use()
        {
            Console.WriteLine("using saw");
        }

        public class Builder : Itooluser 
        {
            //public Hammer hammer { get; set; }
            //public Saw saw { get; set; }

            private Hammer _hammer;
            private Saw _saw;



            //this is setter indipendices we are seeting needed depedency
            public void Buildhouse() 
            {
                _hammer.use();
                _saw.use();
                Console.WriteLine("your house is completed");
            }

            public void setHammer(Hammer hammer)
            {
                _hammer = hammer;
            }

            public void setSaw(Saw saw)
            {
                _saw = saw;
            }



            //this is constructer depedency injection we are saying that ti use builder you have tp provide me al this
            //public  Builder( Hammer hammer , Saw saw)

            //{
            //    /* as you can see this builder class is depended on hammer and saw
            // its directly connected with them with out them it canot work so thiis call
            //depedencies which is needed for class this call tightly couple which is not good for 
            //code maintanibility */
            //    //Hammer hammer = new Hammer();
            //    //Saw saw = new Saw();
            //    Hammer hammer1 = hammer;
            //    Saw saw1 = saw;
            //    hammer.use();
            //    saw.use();
            //    Console.WriteLine("you build has completed");
            //}
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //Hammer hammer = new Hammer();
                //Saw saw = new Saw();
                //Builder builder = new Builder(hammer , saw);


                //setter DI

                //Hammer hammer
                //    = new Hammer();
                //Saw saw = new Saw();

                //Builder builder = new Builder();

                //builder.hammer = hammer;
                //builder.saw = saw;

                //builder.Buildhouse();

                Hammer hammer = new Hammer();
                Saw saw = new Saw();
                Builder builder = new Builder();

                builder.setHammer(hammer);
                builder.setSaw(saw);
                builder.Buildhouse();

                
            }
        }
    }
}
