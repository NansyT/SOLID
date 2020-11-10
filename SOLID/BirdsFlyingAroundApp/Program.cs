using System;
using System.Collections.Generic;

namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>() {
                new Kiwi(),
                new Goose("chainsaw")
            };

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird.Draw());
                Console.WriteLine(bird.SetLocation(200, 420));
                if (bird is IFly)
                {
                    Console.WriteLine(((IFly)bird).SetAltitude(48));
                }
            }
        }
    }
}
