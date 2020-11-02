using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    abstract class Quadrilateral : Polygon
    {
        private double sideD;

        public double SideD
        {
            get { return sideD; }
            set { sideD = value; }
        }
        private double vertexD;

        public double VertexD
        {
            get { return vertexD; }
            set { vertexD = value; }
        }

        public override double CalculateCircumference()
        {
            return SideA + SideB + SideC + SideD;
        }
        
    }
}
