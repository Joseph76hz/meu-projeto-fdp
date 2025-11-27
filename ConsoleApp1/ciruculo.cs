using System;

namespace Area
{
    class Ciruculo
    {
        public static double AreaCirculo(int args)
        {
            // a = pi * r^2
            double area = 0D;
            int raio = args;
            area = Math.PI * Math.Pow(raio, 2);
            return area;
        }
    }
}