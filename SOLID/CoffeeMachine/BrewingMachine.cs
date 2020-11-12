using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    abstract class BrewingMachine
    {
        private bool isON;

        protected bool IsON
        {
            get { return isON; }
            set { isON = value; }
        }
        private float water;

        public float Water
        {
            get { return water; }
            private set { water = value; }
        }
        private float maxWater;

        public float MaxWater
        {
            get { return maxWater; }
            private set { maxWater = value; }
        }
        private bool waterHeated;

        public bool WaterHeated
        {
            get { return waterHeated; }
            set { waterHeated = value; }
        }

        public BrewingMachine()
        {
            IsON = false;
            MaxWater = 1000;
            WaterHeated = false;
        }

        public string HeatWater()
        {
            if (IsON == true)
            {
                if (WaterHeated != true)
                {
                    waterHeated = true;
                    return "I'm heating water... Now you can brew a drink.";
                }
                else
                {
                    return "Water is already hot... You just heated it, no need to waste energy.";
                }
            }
            else
            {
                return "You look at the coffee machine... It is not turned on. You can't heat water if the machine isn't turned on...";
            }
        }

        public string ChangeState()
        {
            if (IsON)
            {
                IsON = false;
                return "You look at the coffee machine... It is turned off";
            }
            else
            {
                IsON = true;
                return "You look at the coffee machine... It is turned on";
            }
        }

        public string FillWater(float newWater)
        {
            if (Water < MaxWater)
            {
                Water += newWater;
                if (Water > MaxWater)
                {
                    Water -= (Water - MaxWater);
                    return "Too much water was poured into the machine. Don't worry the machine drank it for you";
                }
                else
                {
                    return "You poured water into the coffee machine successfully";
                }
            }
            else
            {
                return "The machine is already filled to the brim. You don't want to overfill it do you?";
            }
        }
    }
}
