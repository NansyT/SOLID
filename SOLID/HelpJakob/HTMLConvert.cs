using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakob
{
    class HTMLConvert : IConvert
    {
        public string ConvertMessage(string message)
        {
            return "<html><body>" + message + "</body></html>";
        }
    }
}
