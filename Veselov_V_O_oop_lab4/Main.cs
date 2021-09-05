using System;
using System.Collections.Generic;
using System.Text;

namespace Veselov_V_O_oop_lab4
{
    class Main
    {
        public static void main(String[] args) {
            Triangle triangle = new Triangle();
            triangle.setBase(10);
            triangle.setHeight(6);
            Console.WriteLine(triangle.show());
        }
    }
}
