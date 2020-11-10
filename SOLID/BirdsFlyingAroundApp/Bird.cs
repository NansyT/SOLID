using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    abstract class Bird
    {
        private double longitude;

        public double Longitude
        {
            get { return longitude; }
            private set { longitude = value; }
        }
        private double latitude;

        public double Latitude
        {
            get { return latitude; }
            private set { latitude = value; }
        }

        public Bird(double longitude, double latitude)
        {
            SetLocation(longitude, latitude);
        }

        public abstract void SetLocation(double longitude, double latitude);
        public abstract void Draw();
    }
}
