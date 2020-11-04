using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            cards.Add(new DebitCard("Lars String"));
            cards.Add(new Maestro("Karl Int"));
            cards.Add(new Mastercard("Hans List"));
            cards.Add(new Visa("Lise Char"));
            cards.Add(new VisaElectron("Sanne Bool"));

            foreach (Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }

            Console.ReadLine();
        }
    }
}
