using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface IExpire
    {
        /// <summary>
        /// The day your card expires (dies)
        /// </summary>
        DateTime ExpiryDate { get; set; }
    }
}
