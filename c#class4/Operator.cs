using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_class4
{
    internal class Box
    {

        private double length;
        private double breadth;
        private double height;
        

        public double calcVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        //operator overloading

        public static Box operator+(Box b1,Box b2)
        {
            Box b3 = new Box();
            b3.length = b1.length + b2.length;
            b3.breadth = b1.breadth + b2.breadth;
            b3.height = b1.height + b2.height;

            return b3;

        }

    }
}
