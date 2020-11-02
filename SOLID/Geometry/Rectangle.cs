using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Rectangle : Quadrilateral
    {
        public override double CalculateArea()
        {
            return SideA * SideB;
        }
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideA;
            SideD = sideB;
        }
    }
}
