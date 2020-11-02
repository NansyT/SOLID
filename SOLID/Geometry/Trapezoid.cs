using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Trapezoid : Quadrilateral
    {
        public override double CalculateArea()
        {
            return CalculateH() * SideA;
        }

        public Trapezoid(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideB;
        }

        private double CalculateH()
        {
            double s = (SideA + SideB - SideC + SideD) / 2;
            double t = s * (s - SideA + SideC) * (s - SideB) * (s - SideD);
            return (2 / (SideA - SideC)) * Math.Sqrt(t);
        }
    }
}
