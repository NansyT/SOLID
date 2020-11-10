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

        public override string Draw()
        {
            throw new NotImplementedException();
        }

        public string SetAltitude(double altitude)
        {
            throw new NotImplementedException();
        }

        public override string SetLocation(double longitude, double latitude)
        {
            throw new NotImplementedException();
        }
    }
}
