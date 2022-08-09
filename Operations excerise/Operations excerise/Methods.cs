using System;
using System.Collections.Generic;
using System.Text;

namespace Operations_excerise
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Modulus(int x, int y)
        {
            return x % y;
        }

        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;


        }
    }
}
