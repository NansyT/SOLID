using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CoffeeMachine
{
    class CoffeeMachine : BrewingMachine, IBrewCoffee, IFillCoffeeBeans
    {
        private float coffeeBeansAmount;

        public float CoffeeBeansAmount
        {
            get { return coffeeBeansAmount; }
            set { coffeeBeansAmount = value; }
        }

        private float coffeeBeansMax;

        public float CoffeeBeansMax
        {
            get { return coffeeBeansMax; }
            private set { coffeeBeansMax = value; }
        }
        


        public CoffeeMachine() : base()
        {
            CoffeeBeansMax = 200;
        }

        /// <summary>
        /// Brews coffee for you. Checks if you have enough water and beans.
        /// </summary>
        /// <returns></returns>
        public string BrewCoffee()
        {
            if (IsON == true && WaterHeated == true)
            {

                if (Water >= 200 && coffeeBeansAmount >= 50)
                {

                    return "I brewed " + (Water / 200) + " cups of coffee just for you.";
                }
                else
                {
                    return "Not enough water or coffee beans so I can't brew coffee for you.";
                }
            }
            else
            {
                if (IsON == false)
                {
                    return "You look at the coffee machine... It is in fact turned off. You feel stupid for trying to brew coffee on a macine that's turned off.";
                }
                else
                {
                    return "Your water isn't hot... Do you want ice coffee? Because that's what you'll get";
                }
            }
        }
        /// <summary>
        /// Fills machine with coffee beans. Checks if it's full and if you pour too many into it
        /// </summary>
        /// <param name="newBeans">How many beans you want to fill with</param>
        /// <returns></returns>
        public string FillCoffeeBeans(float newBeans)
        {
            if (CoffeeBeansAmount < CoffeeBeansMax)
            {
                CoffeeBeansAmount += newBeans;
                if (CoffeeBeansAmount > CoffeeBeansMax)
                {
                    CoffeeBeansAmount -= (CoffeeBeansAmount - CoffeeBeansMax);
                    return "Too many coffee beans was poured into the machine. Don't worry the machine ate them for you";
                }
                else
                {
                    return "You poured coffee beans into the machine successfully";
                }
            }
            else
            {
                return "The machine is already filled to the brim. You don't want to overfill it do you?";
            }
        }
    }
}
