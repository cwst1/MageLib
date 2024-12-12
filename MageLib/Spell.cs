using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageLib
{
    public enum SpellType { Offensive, Defensive, Healing }

    public class Spell
    {
        public string Name { get; set; }
        public SpellType Type { get; set; }
        public int ManaCost { get; set; }
        public int Cooldown { get; set; }
        public int Effect { get; set; }

        public override string ToString() =>
            $" SpllName: {Name}, Type: {Type}, ManaCost: {ManaCost}, Cooldown: {Cooldown}, Effect: {Effect}";

        public override bool Equals(object obj) =>
            obj is Spell spell && ToString() == spell.ToString();

        public override int GetHashCode() => ToString().GetHashCode();
    }
}

