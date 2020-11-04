using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyBanker
{
    static class NumGenerator
    {
        /// <summary>
        /// Used to generate numbers for stuff
        /// </summary>
        /// <param name="prefix">Card prefix</param>
        /// <param name="digits">The amount of numbers that needs to be generated (prefix included) </param>
        /// <returns>a generated number</returns>
        public static string GenerateNumber(string prefix, int digits)
        {
            string genNumber = prefix;
            for (; genNumber.Length < digits;)
            {
                Thread.Sleep(25);
                genNumber += new Random().Next(0, 10).ToString();
            }
            
            return genNumber;
        }
    }
}
