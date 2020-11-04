using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface IMonthlyLimit
    {
        /// <summary>
        /// Max amount you can spend in a month
        /// </summary>
        double MonthlyLimit { get; set; }
    }
}
