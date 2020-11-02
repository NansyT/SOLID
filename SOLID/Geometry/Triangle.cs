using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    abstract class Triangle : Polygon
    {
        public override double CalculateCircumference()
        {
            return SideA + SideB + SideC;
        }
    }
}
