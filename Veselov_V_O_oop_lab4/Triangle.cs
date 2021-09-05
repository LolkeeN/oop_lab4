using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab4
{
    class Triangle : CGraphicsObject
    {
        private double height;
        private double baseOfTriangle;

        public override double getSquare() {
            return (height * baseOfTriangle) / 2;
        }

        public double getHeight() {
            return height;
        }

        public double getBase() {
            return baseOfTriangle;
        }

        public void setHeight(double height) {
            this.height = height;
        }

        public void setBase(double baseOfTriangle) {
            this.baseOfTriangle = baseOfTriangle;
        }

        public override String show()
        {
            return "height: " + height + ", base: " + baseOfTriangle + ", square: " + this.getSquare();
        }

        public Triangle(double baseOfTriangle, double height) {
            this.baseOfTriangle = baseOfTriangle;
            this.height = height;
        }

        public Triangle() { }


        public static bool operator >=(Triangle triangle, Triangle triangle1)
        {
            return triangle.getSquare() >= triangle1.getSquare();
        }

        public static bool operator <=(Triangle triangle, Triangle triangle1)
        {
            return triangle.getSquare() <= triangle1.getSquare();
        }
    }
}
