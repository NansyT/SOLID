using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Mastercard : Card, IExpire, ICreditLimit, IMonthlyLimit, IDailyLimit
    {
        public Mastercard(string name)
        {
            CardType = "Mastercard";
            FullName = name;
            string[] prefixes = new string[] { "51", "52", "53", "54", "55" };
            CardPrefix = prefixes[new Random().Next(0, prefixes.Length)];
            CardNumber = NumGenerator.GenerateNumber(CardPrefix, 16);
            ExpiryDate = DateTime.Today.AddYears(5);
            CreditLimit = 40000;
            MonthlyLimit = 30000;
            DailyLimit = 5000;
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
            set { creditLimit = value; }
        }

        private double monthlyLimit;
        public double MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }

        private double dailyLimit;
        public double DailyLimit
        {
            get { return dailyLimit; }
            set { dailyLimit = value; }
        }

        public override string ToString()
        {
            return base.ToString()
                + "Kortets udløbsdato: " + ExpiryDate.ToString("MM/yy") + "\n"
                + "Kredit grænse: " + CreditLimit + "\n"
                + "Månedlig grænse: " + MonthlyLimit + "\n"
                + "Daglig grænse: " + DailyLimit + "\n";
        }
    }
}
