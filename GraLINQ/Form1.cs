using MageLib;
using System;

namespace GraLINQ
{
    public partial class Form1 : Form
    {
        private Guild guild = new Guild();
        public Form1()
        {
            InitializeComponent();
            LoadGuildData();
        }

        private void LoadGuildData()
        {
            guild.AddMage(new Mage
            {
                Name = "Saruman",
                Level = 7,
                Intelligence = 28,
                CurrentHealth = 30,
                Dexterity = 14,
                MaxMana = 90,
                SpellBook = new SpellBook
    {
        new Spell { Name = "Lightning Bolt", Type = SpellType.Offensive, ManaCost = 25, Effect = 80 },
        new Spell { Name = "Frost Armor", Type = SpellType.Defensive, ManaCost = 12, Effect = 40 }
    }
            });

            guild.AddMage(new Mage
            {
                Name = "Morgana",
                Level = 6,
                Intelligence = 26,
                CurrentHealth = 30,
                Dexterity = 13,
                MaxMana = 85,
                SpellBook = new SpellBook
    {
        new Spell { Name = "Poison Cloud", Type = SpellType.Offensive, ManaCost = 18, Effect = 60 },
        new Spell { Name = "Healing Light", Type = SpellType.Healing, ManaCost = 15, Effect = 45 }
    }
            });

            guild.AddMage(new Mage
            {
                Name = "Alatar",
                Level = 10,
                Intelligence = 35,
                CurrentHealth = 30,
                Dexterity = 16,
                MaxMana = 120,
                SpellBook = new SpellBook
    {
        new Spell { Name = "Earthquake", Type = SpellType.Offensive, ManaCost = 30, Effect = 120 },
        new Spell { Name = "Stone Shield", Type = SpellType.Defensive, ManaCost = 20, Effect = 70 },
        new Spell { Name = "Life Surge", Type = SpellType.Healing, ManaCost = 22, Effect = 60 }
    }
            });

            guild.AddMage(new Mage
            {
                Name = "Radagast",
                Level = 4,
                Intelligence = 22,
                CurrentHealth = 30,
                Dexterity = 10,
                MaxMana = 70,
                SpellBook = new SpellBook
    {
        new Spell { Name = "Nature's Touch", Type = SpellType.Healing, ManaCost = 10, Effect = 35 },
        new Spell { Name = "Entangling Roots", Type = SpellType.Defensive, ManaCost = 8, Effect = 30 }
    }
            });

            guild.AddMage(new Mage
            {
                Name = "Elminster",
                Level = 12,
                Intelligence = 40,
                CurrentHealth = 30,
                Dexterity = 17,
                MaxMana = 150,
                SpellBook = new SpellBook
    {
        new Spell { Name = "Meteor Swarm", Type = SpellType.Offensive, ManaCost = 50, Effect = 200 },
        new Spell { Name = "Arcane Barrier", Type = SpellType.Defensive, ManaCost = 25, Effect = 100 },
        new Spell { Name = "Greater Heal", Type = SpellType.Healing, ManaCost = 30, Effect = 80 }
    }
            });

        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void allMagesButton_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();

            var allMages = guild.GetAllMages();  // GetAllMages() zwraca IEnumerable<Mage>


            foreach (var mage in allMages)
            {
                richTextBoxResults.AppendText(mage.ToString());
                richTextBoxResults.AppendText(Environment.NewLine);
            }

        }



        private void btnGetExperiencedMages_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();
            int level = int.Parse(txtLevel.Text);
            foreach (var mage in guild.GetExperiencedMages(level))
            {
                richTextBoxResults.AppendText(mage.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }

        private void btnGetTalentedMages_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();
            int maxLevel = int.Parse(txtMaxLevel.Text);
            foreach (var mage in guild.GetTalentedMages(maxLevel))
            {
                richTextBoxResults.AppendText(mage.ToString() + Environment.NewLine + Environment.NewLine);
            }
        }

        private void btnGetTotalBattlePotential_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();
            int totalMana = guild.GetTotalBattlePotential();
            richTextBoxResults.AppendText($"Total Battle Potential (Mana): {totalMana}" + Environment.NewLine);
        }

        private void btnGetMagesWithArsenal_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();
            int minSpells = int.Parse(txtMinSpells.Text);
            foreach (var mage in guild.GetMagesWithArsenal(minSpells))
            {
                richTextBoxResults.AppendText($"Name: {mage.Name}, Spells: {mage.SpellCount}, Mana: {mage.Mana}" + Environment.NewLine + Environment.NewLine);
            }
        }

        private void btnGetVersatileMages_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();
            foreach (var mage in guild.GetVersatileMages())
            {
                richTextBoxResults.AppendText($"Name: {mage.Name}, Level: {mage.Level}, Average Attributes: {mage.AverageAttribute:F2}" + Environment.NewLine + Environment.NewLine);
            }
        }

        private void btnGetUniqueSpells_Click(object sender, EventArgs e)
        {
            richTextBoxResults.Clear();

            var uniqueSpells = guild.GetUniqueSpells();

            foreach (var spell in uniqueSpells)
            {
                richTextBoxResults.AppendText(spell.ToString() + "\n\n"); // Dodanie pustej linii dla czytelnoœci
            }
        }

        private void btnCheckIfAnyoneLostConsciousness_Click(object sender, EventArgs e)
        {
            // binarka czy przytomny
            bool hasLostConsciousness = guild.HasMageLostConsciousness();
            richTextBoxResults.Clear();
            if (hasLostConsciousness)
            {
                richTextBoxResults.AppendText("At least one mage has lost consciousness (Health = 0).\n");
            }
            else
            {
                richTextBoxResults.AppendText("No mage has lost consciousness (Health > 0).\n");
            }
        }
    }
}
