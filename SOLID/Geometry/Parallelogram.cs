using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Parallelogram : Quadrilateral
    {
        private double v;

        public double V
        {
            get { return v; }
            set { v = value; }
        }

        public override double CalculateArea()
        {
            return SideA * SideB * Math.Sin(V);
        }

        
        public Parallelogram(double sideA, double sideB, double vertex)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideA;
            SideD = sideB;
            V = vertex;
        }
    }
}
