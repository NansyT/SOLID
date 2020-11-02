using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class RightTriangle : Triangle
    {
        public override double CalculateArea()
        {
            return (SideA * SideB) / 2;
        }

        public RightTriangle(double katete1, double katete2)
        {
            SideA = katete1;
            SideB = katete2;
        }
    }
}
