using System;
using System.Collections.Generic;
using System.Text;

namespace HelpLone
{
    class Knight : ICharacter, ISlash, ICleave, IBash, IGotShield
    {
        public string Bash()
        {
            return "I'm bashing someones head in";
        }

        public string Cleave()
        {
            return "I'm cleaving someone";
        }

        public string Die()
        {
            return "I'm dying gracefully";
        }

        public string Fight()
        {
            return "I'm fighting honorably";
        }

        public string Heal()
        {
            return "I'm healing good";
        }

        public string RaiseShield()
        {
            return "I'm raising my mighty shield";
        }

        public string ShieldGlare()
        {
            return "My shield is glaring at someone";
        }

        public string Slash()
        {
            return "I'm slashing someone hard";
        }
    }
}
