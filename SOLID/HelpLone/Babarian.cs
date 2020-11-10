using System;
using System.Collections.Generic;
using System.Text;

namespace HelpLone
{
    class Babarian : ICharacter, ICleave, ISlash, IBash
    {
        public string Bash()
        {
            return "I'm bashing someone's feet";
        }

        public string Cleave()
        {
            return "I'm cleaving someone in half";
        }

        public string Die()
        {
            return "I'm dying brutally";
        }

        public string Fight()
        {
            return "I'm fighting someone big";
        }

        public string Heal()
        {
            return "I'm healing my pain away";
        }

        public string Slash()
        {
            return "I'm slashing till someone is dead";
        }
    }
}
