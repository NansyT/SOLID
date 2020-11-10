using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    abstract class Bird
    {
        public abstract string SetLocation(double longitude, double latitude);
        public abstract string Draw();
    }
}
