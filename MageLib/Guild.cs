using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageLib
{
    public class Guild
    {
        private List<Mage> _mages = new List<Mage>();

        public void AddMage(Mage mage) => _mages.Add(mage);

        public override string ToString() => string.Join("\n", _mages.Select(mage => mage.ToString()));

        // Zapytania LINQ:
        //IEnumerable<T> wynik = kolekcja.Where(element => warunek);

        public IEnumerable<Mage> GetAllMages() => _mages.OrderBy(m => m.Name);//.Skip(1);//.Take(1);

        public IEnumerable<Mage> GetExperiencedMages(int level) =>
            _mages.Where(m => m.Level > level).OrderBy(m => m.Level);

        public IEnumerable<Mage> GetTalentedMages(int maxLevel) =>
            _mages.Where(m => m.Intelligence > 20 && m.Level <= maxLevel)
                  .OrderByDescending(m => m.Intelligence);

        public int GetTotalBattlePotential() =>
            _mages.Where(m => m.Level > 2 && m.Dexterity > 10).Sum(m => m.MaxMana);

        public IEnumerable<(string Name, int SpellCount, int Mana)> GetMagesWithArsenal(int minSpells) =>
            _mages.Where(m => m.SpellBook.Count >= minSpells)
                  .OrderByDescending(m => m.SpellBook.Count)
                  .Select(m => (m.Name, m.SpellBook.Count, m.MaxMana));

        public IEnumerable<(string Name, int Level, double AverageAttribute)> GetVersatileMages() =>
            _mages.Select(m => (m.Name, m.Level,
                AverageAttribute: (m.Strength + m.Dexterity + m.Intelligence) / 3.0))
                  .OrderByDescending(m => m.AverageAttribute);
        
        public IEnumerable<Spell> GetUniqueSpells()
        {
            return _mages.SelectMany(m => m.SpellBook).Distinct();
        }

        public bool HasMageLostConsciousness()
        {
            return _mages.Any(mage => mage.CurrentHealth == 0);
        }
    }

}
