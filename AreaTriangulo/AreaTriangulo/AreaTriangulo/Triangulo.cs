using System;

namespace AreaTriangulo
{
    class Triangulo
    {
        public double L1; 
        public double L2;
        public double L3;

        public double Area() 
        {
            double p = (L1 + L2 +L3) / 2;
            return Math.Sqrt(p * (p - L1) * (p - L2) * (p - L3));
           
        }
    }
}
