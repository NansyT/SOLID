using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    class Goose : Bird, IFly
    {
        private string weapon;
        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Goose(string weapon)
        {
            Weapon = weapon;
        }
        public override string Draw()
        {
            return "Drawing goose with a " + Weapon + " for weapon. Just pretend it's there...";
        }

        public string SetAltitude(double altitude)
        {
            return "Goose's altitude is :" + altitude;
        }

        public override string SetLocation(double longitude, double latitude)
        {
            return "The Goose is located at : " + longitude + " " + latitude;
        }
    }
}
