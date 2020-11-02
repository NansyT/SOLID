using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    abstract class Polygon : Shape
    {
        private double sideA;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        private double sideB;

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        private double sideC;

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        
    }
}
