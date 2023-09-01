using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica001
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector VectorA = new Vector(2, 3);
            Vector VectorB = new Vector(1, 4);

            Console.WriteLine("VectorA: X = " + VectorA.X + ", Y = " + VectorA.Y );
            Console.WriteLine("VectorB: X = " + VectorB.X + ", Y = " + VectorB.Y);
            
        

        double distancia = VectorA.CalcularDistance(VectorB);
        Console.WriteLine("Distancia entre VectorA y VectorB: " + distancia);
        }
}
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double CalcularDistance(Vector other)
        {
            double deltaX = X - other.X;
            double deltaY = Y - other.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
