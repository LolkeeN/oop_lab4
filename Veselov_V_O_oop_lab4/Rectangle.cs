using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab4
{
    class Rectangle : CGraphicsObject
    {
        private double width;
        private double length;

        public double getWidht() {
            return width;
        }

        public double getLetgth() {
            return length;
        }

        public void setLetgth(double length) {
            this.length = length;
        }

        public void setWidth(double width) {
            this.width = width;
        }

        public override double getSquare()
        {
            return length * width;
        }

        public override String show()
        {
            return "lenght: " + length + ", width: " + width + ", square: " + this.getSquare();
        }

        public Rectangle(double length, double width) {
            this.length = length;
            this.width = width;
        }

        public Rectangle() { }


        public static bool operator >=(Rectangle rectangle, Rectangle rectangle1)
        {
            return rectangle.getSquare() >= rectangle1.getSquare();
        }

        public static bool operator <=(Rectangle rectangle, Rectangle rectangle1)
        {
            return rectangle.getSquare() <= rectangle1.getSquare();
        }
    }
}