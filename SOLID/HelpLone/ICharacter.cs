using System;
using System.Collections.Generic;
using System.Text;

namespace HelpLone
{
    interface ICharacter
    {
        public string Die();

        public string Heal();

        public string Fight();
    }
}
