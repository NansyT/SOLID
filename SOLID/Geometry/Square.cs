﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Square : Quadrilateral
    {
        public override double CalculateArea()
        {
            return Math.Pow(SideA, 2);
        }
        public Square(double side)
        {
            SideA = side;
            SideB = side;
            SideC = side;
            SideD = side;
        }
    }
}
