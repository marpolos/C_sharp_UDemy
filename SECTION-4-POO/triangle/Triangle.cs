using System;

namespace POO
{
    class Triangle
    {
        public double A = 0.0;
        public double B = 0.0;
        public double C = 0.0;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            double result = Math.Sqrt(p * (p-A) * (p-B) * (p-C));
            return result;
        }
    }
}