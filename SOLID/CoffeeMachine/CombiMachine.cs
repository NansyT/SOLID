using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine
{
    class CombiMachine : CoffeeMachine, IBrewTea, IFillTea
    {
        private float teaAmount;

        public float TeaAmount
        {
            get { return teaAmount; }
            set { teaAmount = value; }
        }
        private float maxTea;

        public float MaxTea
        {
            get { return maxTea; }
            set { maxTea = value; }
        }

        public CombiMachine() : base()
        {
            MaxTea = 200;
        }
        /// <summary>
        /// Brews tea for you. Checks if you have enough water and tea leaves.
        /// </summary>
        /// <returns></returns>
        public string BrewTea()
        {
            if (IsON == true && WaterHeated == true)
            {

                if (Water >= 200 && TeaAmount >= 50)
                {

                    return "I brewed " + (Water / 200) + " cups of tea just for you.";
                }
                else
                {
                    return "Not enough water or tea leaves so I can't brew tea for you.";
                }
            }
            else
            {
                if (IsON == false)
                {
                    return "You look at the combi machine... It is in fact turned off. You feel stupid for trying to brew a drink on a macine that's turned off.";
                }
                else
                {
                    return "Your water isn't hot... Do you want ice tea? Because that's what you'll get";
                }
            }
        }
        /// <summary>
        /// Fills machine with tea leaves. Checks if it's full and if you pour too many into it
        /// </summary>
        /// <param name="newBeans">How many beans you want to fill with</param>
        /// <returns></returns>
        public string FillTea(float newTea)
        {
            if (TeaAmount < MaxTea)
            {
                TeaAmount += newTea;
                if (TeaAmount > maxTea)
                {
                    TeaAmount -= (TeaAmount - MaxTea);
                    return "Too many tea leaves was poured into the machine. Don't worry the machine ate it for you";
                }
                else
                {
                    return "You poured tea leaves into the coffee machine successfully";
                }
            }
            else
            {
                return "The machine is already filled to the brim. You don't want to overfill it do you?";
            }
        }
    }
}
