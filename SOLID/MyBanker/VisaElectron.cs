using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class VisaElectron : Card, IExpire, IMonthlyLimit
    {
        public VisaElectron(string name)
        {
            CardType = "Visa Electron";
            FullName = name;
            string[] prefixes = new string[] { "4026", "417500", "4508", "4844", "4913", "4917" };
            CardPrefix = prefixes[new Random().Next(0, prefixes.Length)];
            CardNumber = NumGenerator.GenerateNumber(CardPrefix, 16);
            ExpiryDate = DateTime.Today.AddYears(5);
            MonthlyLimit = 10000;
        }
        private DateTime expiryDate;
        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        private double monthlyLimit;
        public double MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }

        public override string ToString()
        {
            return base.ToString()
                + "Kortets udløbsdato: " + ExpiryDate.ToString("MM/yy") + "\n"
                + "Månedlig grænse: " + MonthlyLimit + "\n";
        }
    }
}
