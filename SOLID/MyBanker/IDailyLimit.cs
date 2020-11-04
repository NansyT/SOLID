using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface IDailyLimit
    {
        /// <summary>
        /// Max amount you can spend on a day. (So many limits)
        /// </summary>
        double DailyLimit { get; set; }
    }
}
