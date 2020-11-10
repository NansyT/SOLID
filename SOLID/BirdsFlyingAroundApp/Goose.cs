using System;
using System.Collections.Generic;
using System.Text;

namespace BirdsFlyingAroundApp
{
    class Goose : Bird, IFly
    {
        private string weapon;

        public Goose(string weapon, double longitude, double latitude, double altitude) : base(longitude, latitude)
        {
            Weapon = weapon;
            SetAltitude(altitude);
        }

        public string Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }


        public override void Draw()
        {
            
        }

        public override void SetLocation(double logitude, double latitude)
        {
            
        }

        public void SetAltitude(double altitude)
        {
            
        }
    }
}
