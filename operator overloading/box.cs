using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    internal class box
    {

        public int height { get; set; }
        public int width { get; set; }


        //in const we have to initialize value when we are declaring it so it will be same for all instance/object
        public const int corners = 4;


        //we can assign value on run time with readonly keyword 
        public readonly string color;

        public box(string Color)
        {
            color = Color;
        }


        public box(int x , int y)
        {
            height = x;
            width = y;
        }

        //so we cant use operator normally on obijects so we have to override them 

        //this is syntax for operator overloading we have to pass how many objects we have to add and then return the new object
        public static box operator +(box b1, box b2)
        {
            int newHeight = b1.height + b2.height;
            int newWidth = b1.width + b2.width;

            return new box(newWidth, newHeight);
        }


        //when we print direct obj then csharp internallyy call tostring method we have to also override it sio we have proper output
        public override string ToString()
        {
            return $"Width = {width}, Height = {height}";
        }

        public void details()
        {
            Console.WriteLine($"box has {color} and {corners} corners and it has {width} width and {height} height");
        }
    }
}
