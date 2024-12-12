using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageLib
{
    public class Mage
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentMana { get; set; }
        public int MaxMana { get; set; }
        public int Damage { get; set; }
        public int PhysicalResistance { get; set; }
        public int FireResistance { get; set; }
        public int FrostResistance { get; set; }
        public int PoisonResistance { get; set; }
        public SpellBook SpellBook { get; set; } = new SpellBook();

        public override string ToString() =>
            $"Name: {Name}, Level: {Level}, Experience: {Experience}, " +
            $"Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}, " +
            $"CurrentHealth: {CurrentHealth}/{MaxHealth}, CurrentMana: {CurrentMana}/{MaxMana}, " +
            $"Resistances - Physical: {PhysicalResistance}, Fire: {FireResistance}, " +
            $"Frost: {FrostResistance}, Poison: {PoisonResistance}{Environment.NewLine} Spells:{Environment.NewLine}{SpellBook}{Environment.NewLine}";
    }

}
