using System;

namespace BirdsFlyingAroundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiwi kiwi = new Kiwi();
            Goose goose = new Goose("knife");

            Console.WriteLine(kiwi.Draw() + "\n" + kiwi.SetLocation(3424, 342523));
            Console.WriteLine(goose.Draw() + "\n" + goose.SetLocation(38742, 23874) + "\n" + goose.SetAltitude(387));
        }
    }
}
