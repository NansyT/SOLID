using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class DebitCard : Card
    {
        public DebitCard(string name)
        {
            CardType = "Debit Card";
            FullName = name;
            CardPrefix = "2400";
            CardNumber = NumGenerator.GenerateNumber(CardPrefix, 16);
        }
    }
}
