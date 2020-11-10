using System;
using System.Collections.Generic;
using System.Text;

namespace HelpLone
{
    class Witch : ICharacter, ITeleport, IGotShield
    {
        public string Die()
        {
            return "I'm dying painfully";
        }

        public string Fight()
        {
            return "I'm fighting magically";
        }

        public string Heal()
        {
            return "I'm healing effectively";
        }

        public string RaiseShield()
        {
            return "I'm raising my shield";
        }

        public string ShieldGlare()
        {
            return "I'm using shield glare";
        }

        public string Teleport(int x, int y)
        {
            return "I'm teleporting away into the sunset at: " + x + " and " + y;
        }

        
    }
}
