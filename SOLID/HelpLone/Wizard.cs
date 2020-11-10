using System;
using System.Collections.Generic;
using System.Text;

namespace HelpLone
{
    internal class Wizard : ICharacter, ITeleport, IThrowMagicMissile, IThrowFrostNova
    {
        public string Die()
        {
            return "I'm dying horribly";
        }

        public string Fight()
        {
            return "I'm fighting someone awful";
        }

        public string Heal()
        {
            return "I'm healing all day long";
        }

        public string Teleport(int x, int y)
        {
            return "I'm teleporting fast to: " + x + " and "+ y;
        }

        public string ThrowFrostNova()
        {
            return "I'm throwing all my frost in a nova at someone";
        }

        public string ThrowMagicMissile()
        {
            return "I'm throwing a missile filled with magic";
        }
    }
}
