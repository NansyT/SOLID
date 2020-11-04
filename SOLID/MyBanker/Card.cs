using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    abstract class Card
    {
        private string cardType;

        public string CardType
        {
            get { return cardType; }
            protected set { cardType = value; }
        }
        private string cardprefix;
        public string CardPrefix
        {
            get { return cardprefix; }
            protected set { cardprefix = value; }
        }

        private string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            protected set { cardNumber = value; }
        }
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private string accountnumber;

        public string AccountNumber
        {
            get { return accountnumber = NumGenerator.GenerateNumber("",14); }
        }

        public override string ToString()
        {
            return "Kort holder: " + fullName + "\n" +
                   "Kort type: " + cardType + "\n" +
                   "Kort nummer: " + cardNumber + "\n" +
                   "Konto nummer: " + accountnumber + "\n";
        }
    }
}
