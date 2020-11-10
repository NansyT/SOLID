using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    /// <summary>
    /// Bird with (technically) the shortest beak.
    /// </summary>
    class Kiwi : Bird
    {
        public override string Draw()
        {
            return "Drawing kiwi bird. Just pretend it's there...";
        }

        public override string SetLocation(double longitude, double latitude)
        {
            return "Kiwi is located at: " + longitude + " " + latitude;
        }
    }
}
