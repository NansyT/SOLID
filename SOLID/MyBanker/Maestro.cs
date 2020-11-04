using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Maestro : Card, IExpire
    {
        public Maestro(string name)
        {
            CardType = "Maestro";
            FullName = name;
            string[] prefixes = new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
            CardPrefix = prefixes[new Random().Next(0, prefixes.Length)];
            CardNumber = NumGenerator.GenerateNumber(CardPrefix, 19);
        }
        private DateTime expiryDate;
        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = DateTime.Today.AddYears(5).AddMonths(8); }
        }

        public override string ToString()
        {
            return base.ToString() 
                + "Kortets udløbsdato: " + expiryDate.ToString("MM/yy") + "\n";
        }
    }
}
