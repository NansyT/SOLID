using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Visa : Card, IExpire, IMonthlyLimit
    {
        public Visa(string name)
        {
            CardType = "Visa";
            FullName = name;
            string[] prefixes = new string[] { "4026", "417500", "4508", "4844", "4913", "4917" };
            CardPrefix = prefixes[new Random().Next(0, prefixes.Length)];
            CardNumber = NumGenerator.GenerateNumber(CardPrefix, 16);
        }

        private DateTime expiryDate;
        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }
        private double creditLimit;
        public double CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = 20000; }
        }
        private double monthlyLimit;
        public double MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = 25000; }
        }

        public override string ToString()
        {
            return base.ToString()
                + "Kortets udløbsdato: " + expiryDate.ToString("MM/yy") + "\n"
                + "Kredit grænse: " + creditLimit + "\n"
                + "Månedlig grænse: " + monthlyLimit + "\n";
        }
    }
}
