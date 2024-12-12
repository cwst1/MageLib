using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageLib
{
    public class SpellBook : List<Spell>
    {
        public override string ToString() => string.Join("\n", this.Select(spell => spell.ToString()));
    }

}
